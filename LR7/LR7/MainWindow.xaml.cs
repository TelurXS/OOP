using LR7.Commands;
using LR7.Services;
using Microsoft.Win32;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LR7;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow(
		App app, 
		SettingsService settingsService,
		SyntaxHighlightingService syntaxHighlightingService, 
		DataFormatService dataFormatService)
	{
		App = app;
		SettingsService = settingsService;
		SyntaxHighlightingService = syntaxHighlightingService;
		DataFormatService = dataFormatService;

		Settings = SettingsService.Load();
		ChangeTheme(Settings.Theme);
		ChangeLanguage(Settings.Language, false);

		InitializeComponent();

		ChangeThemeCommand = new RelayCommand<string>(ChangeTheme);
		ChangeLanguageCommand = new RelayCommand<string>(x => ChangeLanguage(x));
		OpenFileCommand = new RelayCommand<string>(OpenFile);
		SaveFileCommand = new RelayCommand<string>(SaveFile);
		InsertImageCommand = new RelayCommand<string>(InsertImage, TextBoxNotEmpty);
		SetTextAligmentCommand = new RelayCommand<string>(SetTextBoxAligment, TextBoxNotEmpty);
		SetSyntaxHighlightingCommand = new RelayCommand<string>(SetSyntaxHighlighting);

		DataContext = this;
		ComboBox_FontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
		ComboBox_FontSize.ItemsSource = Enumerable.Range(6, 30).Select(x => x * 2);
	}

	public ICommand ChangeThemeCommand { get; init; }
	public ICommand ChangeLanguageCommand { get; init; }
	public ICommand OpenFileCommand { get; init; }
	public ICommand SaveFileCommand { get; init; }
	public ICommand InsertImageCommand { get; init; }
	public ICommand SetTextAligmentCommand { get; init; }
	public ICommand SetSyntaxHighlightingCommand { get; init; }

	public App App { get; }
	public SettingsService SettingsService { get; }
	public SyntaxHighlightingService SyntaxHighlightingService { get; }
	public DataFormatService DataFormatService { get; }

	private Settings Settings { get; set; }

	private void ChangeTheme(string value)
	{
		Settings.Theme = value;
		SettingsService.Save(Settings);

		ResourceDictionary theme = new ResourceDictionary();
		theme.Source = new Uri(value, UriKind.Relative);

		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(theme);
		InvalidateVisual();
	}

	private void ChangeLanguage(string value, bool reload = true)
	{
		Settings.Language = value;
		SettingsService.Save(Settings);

		Thread.CurrentThread.CurrentCulture = new CultureInfo(value);
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(value);
		InvalidateVisual();

		if (reload)
			App.Reload();
	}

	private void OpenFile(string format)
	{
		OpenFileDialog dialog = new OpenFileDialog()
		{
			Filter = $"*.{format.ToLower()}|*.{format.ToLower()}",
		};

		if (dialog.ShowDialog() is false)
			return;

		using (var stream = File.OpenRead(dialog.FileName))
		{
			TextRange range = new TextRange(RichTextBox_Content.Document.ContentStart, RichTextBox_Content.Document.ContentEnd);
			range.Load(stream, DataFormatService.GetDataFormat(format));
		}
	}

	private void SaveFile(string format)
	{
		SaveFileDialog dialog = new SaveFileDialog()
		{
			Filter = $"*.{format.ToLower()}|*.{format.ToLower()}",
		};

		if (dialog.ShowDialog() is false)
			return;

		using (var stream = File.OpenWrite(dialog.FileName))
		{
			TextRange range = new TextRange(RichTextBox_Content.Document.ContentStart, RichTextBox_Content.Document.ContentEnd);
			range.Save(stream, DataFormatService.GetDataFormat(format));
		}
	}

	private void InsertImage(string format)
	{
		OpenFileDialog dialog = new OpenFileDialog()
		{
			Filter = $"*.{format.ToLower()}|*.{format.ToLower()}",
		};

		if (dialog.ShowDialog() is false)
			return;

		string path = dialog.FileName;

		BitmapImage bitmap = new BitmapImage(new Uri(path));

		Image image = new Image
		{
			Source = bitmap,
			Width = bitmap.Width,
			Height = bitmap.Height
		};

		InlineUIContainer container = new InlineUIContainer(image, RichTextBox_Content.CaretPosition);
		RichTextBox_Content.CaretPosition = container.ElementEnd;
	}

	private void SetTextBoxAligment(string value)
	{
		if (Enum.TryParse<TextAlignment>(value, true, out var alignment) is false)
			return;

		var selection = RichTextBox_Content.Selection;

		if (selection.IsEmpty)
		{
			Paragraph paragraph = RichTextBox_Content.CaretPosition.Paragraph;

			if (paragraph is null) return;

			paragraph.TextAlignment = alignment;
		}
		else
		{
			Paragraph paragraph = selection.Start.Paragraph;

			if (paragraph is null) return;

			paragraph.TextAlignment = alignment;
		}
	}

	private void SetSyntaxHighlighting(string value)
	{
		Settings.ShouldHighlightSyntax = bool.Parse(value);
		SettingsService.Save(Settings);

		HighlightSyntax();
	}

	private void HighlightSyntax()
	{
		if (Settings.ShouldHighlightSyntax)
		{
			RichTextBox_Content.TextChanged -= RichTextBox_Content_TextChanged;

			SyntaxHighlightingService.HighlightSyntaxt(RichTextBox_Content);

			RichTextBox_Content.TextChanged += RichTextBox_Content_TextChanged;
		}
	}

	private bool TextBoxNotEmpty(string parameter) => RichTextBox_Content.Selection is not null;

	private void ComboBox_FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (ComboBox_FontFamily.SelectedItem is null)
			return;

		RichTextBox_Content.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, ComboBox_FontFamily.SelectedItem);
	}

	private void ComboBox_FontSize_TextChanged(object sender, TextChangedEventArgs e)
	{
		try
		{
			if (double.TryParse(ComboBox_FontSize.Text, out var result) is false)
				throw new ArgumentException("Wrong font size format");

			RichTextBox_Content.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, result);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Warning);
		}
	}

	private void RichTextBox_Content_SelectionChanged(object sender, RoutedEventArgs e)
	{
		var boldProperty = RichTextBox_Content.Selection.GetPropertyValue(TextElement.FontWeightProperty);
		Button_Bold.IsChecked = (boldProperty != DependencyProperty.UnsetValue) && (boldProperty.Equals(FontWeights.Bold));

		var italicProperty = RichTextBox_Content.Selection.GetPropertyValue(TextElement.FontStyleProperty);
		Button_Italic.IsChecked = (italicProperty != DependencyProperty.UnsetValue) && (italicProperty.Equals(FontStyles.Italic));

		var underlineProperty = RichTextBox_Content.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
		Button_Underline.IsChecked = (underlineProperty != DependencyProperty.UnsetValue) && (underlineProperty.Equals(TextDecorations.Underline));

		var fontFamilyProperty = RichTextBox_Content.Selection.GetPropertyValue(TextElement.FontFamilyProperty);
		ComboBox_FontFamily.SelectedItem = fontFamilyProperty;

		var fontSizeProperty = RichTextBox_Content.Selection.GetPropertyValue(TextElement.FontSizeProperty);
		ComboBox_FontSize.Text = fontSizeProperty.ToString();

		var aligment = RichTextBox_Content.Selection.Start.Paragraph.TextAlignment;
		Button_Allign_Left.IsChecked = aligment.Equals(TextAlignment.Left);
		Button_Allign_Center.IsChecked = aligment.Equals(TextAlignment.Center);
		Button_Allign_Right.IsChecked = aligment.Equals(TextAlignment.Right);
		Button_Allign_Justify.IsChecked = aligment.Equals(TextAlignment.Justify);
	}

	private void RichTextBox_Content_TextChanged(object sender, TextChangedEventArgs e)
	{
		HighlightSyntax();

		TextRange range = new TextRange(RichTextBox_Content.Document.ContentStart, RichTextBox_Content.Document.ContentEnd);
		var text = range.Text.Trim();
		var words = text.Split();

		TextBlock_Words.Text = words.Count().ToString();
		TextBlock_Letters.Text = words.Sum(x => x.Length).ToString();
	}
}
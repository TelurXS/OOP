using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace LR7.Services;

public sealed class SyntaxHighlightingService
{
    public SyntaxHighlightingService(string path)
    {
        Path = path;
        var json = File.ReadAllText(Path);
        Keywords = JsonConvert.DeserializeObject<Dictionary<string, string>>(json)!;
    }

	private string Path { get; init; } = string.Empty;
	private Dictionary<string, string> Keywords { get; } = new();
	private BrushConverter BrushConverter { get; } = new();

	public void HighlightSyntaxt(RichTextBox textBox)
    {
		TextRange textRange = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
		textRange.ClearAllProperties();

		foreach ((string keyword, string color) in Keywords)
		{
			HighlightWords(textBox, keyword, BrushConverter.ConvertFromString(color) as Brush);
		}	
	}

	private void HighlightWords(RichTextBox textBox, string word, Brush? color)
	{
		TextPointer position = textBox.Document.ContentStart;
		
		while (position is not null)
		{
			TextRange? wordRange = FindWordFromPosition(position, word);
		
			if (wordRange is null)
				break;
		
			wordRange.ApplyPropertyValue(TextElement.ForegroundProperty, color);
			position = wordRange.End;
		}
	}

	private TextRange? FindWordFromPosition(TextPointer position, string word)
	{
		while (position is not null)
		{
			if (position.GetPointerContext(LogicalDirection.Forward) == TextPointerContext.Text)
			{
				string textRun = position.GetTextInRun(LogicalDirection.Forward);

				int indexInRun = textRun.IndexOf(word, StringComparison.CurrentCultureIgnoreCase);

				if (indexInRun >= 0)
				{
					TextPointer start = position.GetPositionAtOffset(indexInRun);
					TextPointer end = start.GetPositionAtOffset(word.Length);
					return new TextRange(start, end);
				}
			}
	
			position = position.GetNextContextPosition(LogicalDirection.Forward);
		}
	
		return null;
	}
}

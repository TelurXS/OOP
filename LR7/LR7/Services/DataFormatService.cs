using System.Windows;

namespace LR7.Services;

public class DataFormatService
{
	private static readonly Dictionary<string, string> _formatMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
	{
		{ "TXT", DataFormats.Text },
		{ "RTF", DataFormats.Rtf },
		{ "UnicodeText", DataFormats.UnicodeText },
		{ "HTML", DataFormats.Html },
		{ "Xaml", DataFormats.Xaml },
		{ "XamlPackage", DataFormats.XamlPackage },
		{ "Bitmap", DataFormats.Bitmap },
		{ "FileDrop", DataFormats.FileDrop },
		{ "Csv", DataFormats.CommaSeparatedValue },
		{ "Dib", DataFormats.Dib },
		{ "Tiff", DataFormats.Tiff },
		{ "OEMText", DataFormats.OemText },
		{ "Dif", DataFormats.Dif },
		{ "EnhancedMetafile", DataFormats.EnhancedMetafile },
		{ "SymbolicLink", DataFormats.SymbolicLink },
		{ "Serializable", DataFormats.Serializable }
	};

	public string GetDataFormat(string name)
	{
		if (_formatMappings.TryGetValue(name, out var dataFormat))
		{
			return dataFormat;
		}

		throw new ArgumentException($"Unknown data format: {name}");
	}
}

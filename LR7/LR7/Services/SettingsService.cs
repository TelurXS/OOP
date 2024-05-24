using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace LR7.Services;

public sealed class Settings
{
	public string Theme { get; set; } = string.Empty;
	public string Language { get; set; } = string.Empty;
	public bool ShouldHighlightSyntax { get; set; } = false;
}

public sealed class SettingsService
{
    public SettingsService(string path)
    {
        Path = path;
    }

    private string Path { get; init; } = string.Empty;

	public Settings Load()
	{
		var json = File.ReadAllText(Path);
		return JsonConvert.DeserializeObject<Settings>(json)!;
	}

	public void Save(Settings settings)
	{
		var json = JsonConvert.SerializeObject(settings);
		File.WriteAllText(Path, json);
	}
}

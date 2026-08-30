namespace MeuPrograma;

public sealed class VersionUpdate
{
    public string Version { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public List<string> Changes { get; set; } = new();
}

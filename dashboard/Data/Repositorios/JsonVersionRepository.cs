using System.Text.Json;

namespace MeuPrograma;

public sealed class JsonVersionRepository : IVersionRepository
{
    private readonly string filePath;

    public JsonVersionRepository(string filePath)
    {
        this.filePath = filePath;
    }

    public IReadOnlyList<VersionUpdate> GetUpdates()
    {
        if (!File.Exists(filePath))
            return Array.Empty<VersionUpdate>();

        var json = File.ReadAllText(filePath);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        return JsonSerializer.Deserialize<List<VersionUpdate>>(json, options)
            ?? new List<VersionUpdate>();
    }
}

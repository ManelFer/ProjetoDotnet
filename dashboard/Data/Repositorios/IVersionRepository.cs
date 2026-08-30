namespace MeuPrograma;

public interface IVersionRepository
{
    IReadOnlyList<VersionUpdate> GetUpdates();
}

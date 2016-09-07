using SQLite.Net.Interop;

namespace FomeLine.Repository.Interfaces
{
    public interface IDataStore
    {
        string Path { get; }
        ISQLitePlatform Plataform { get; }
    }
}
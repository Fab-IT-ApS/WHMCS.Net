namespace Whmcs.Interfaces
{
    public interface IJSONService
    {
        T DeserializeJSON<T>(string inputJSON);
    }
}
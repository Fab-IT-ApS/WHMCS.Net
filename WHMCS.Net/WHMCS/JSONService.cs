
using Newtonsoft.Json;
using WHMCS.Interfaces;

namespace WHMCS
{
    public class JSONService : IJSONService
    {
        public T DeserializeJSON<T>(string inputJSON)
        {
            return JsonConvert.DeserializeObject<T>(inputJSON);
        }
    }
}

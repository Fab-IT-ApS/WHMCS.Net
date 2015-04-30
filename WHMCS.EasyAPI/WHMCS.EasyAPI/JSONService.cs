
using Newtonsoft.Json;
using Whmcs.Interfaces;

namespace Whmcs
{
    public class JSONService : IJSONService
    {
        public T DeserializeJSON<T>(string inputJSON)
        {
            return JsonConvert.DeserializeObject<T>(inputJSON);
        }
    }
}

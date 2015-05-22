using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Clients
{
    public class Clients
    {
        [JsonProperty("Client")]
        public IEnumerable<Client> Client { get; set; }
    }
}

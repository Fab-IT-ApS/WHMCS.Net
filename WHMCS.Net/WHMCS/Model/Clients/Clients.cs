using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Clients
{
    public class Clients
    {
        [JsonProperty("Client")]
        public List<Client> Client { get; set; }
    }
}

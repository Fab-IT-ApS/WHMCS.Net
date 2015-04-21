using System.Collections.Generic;
using Newtonsoft.Json;

namespace Whmcs.Model.Clients
{
    public class Clients
    {
        [JsonProperty("Client")]
        public List<Client> Client { get; set; }
    }
}

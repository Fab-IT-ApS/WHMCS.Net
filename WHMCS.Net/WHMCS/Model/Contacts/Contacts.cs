using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Contacts
{
    public class Contacts
    {
        [JsonProperty("contact")]
        public IEnumerable<Contact> contact { get; set; }
    }
}

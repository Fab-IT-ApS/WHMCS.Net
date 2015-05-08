using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Contacts
{
    public class Contacts
    {
        [JsonProperty("contact")]
        public List<Contact> contact { get; set; }
    }
}

using Whmcs.DataStores;

namespace Whmcs.Example
{
    class Program
    {
        static void Main()
        {
            var whmcs = new WhmcsApi("Username", "Password", "Domain", true, new DataStore());

        }
    }
}

using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetBerries();
        foreach (KNamedAPIResource api in apiList.Results) {
            KBerry r = KBerry.GetBerry(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

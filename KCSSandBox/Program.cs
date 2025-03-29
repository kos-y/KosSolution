using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetBerryFlavors();
        foreach (KNamedAPIResource api in apiList.Results) {
            KBerryFlavor r = KBerryFlavor.GetBerryFlavor(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

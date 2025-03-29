using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetBerryFirmnesses();
        foreach (KNamedAPIResource api in apiList.Results) {
            KBerryFirmness r = KBerryFirmness.GetBerryFirmness(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

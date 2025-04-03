using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
#if true
        KNamedAPIResourceList apiList = KPokeAPI.GetItemAttributes();
        foreach (KNamedAPIResource api in apiList.Results) {
            var r = KItemAttribute.GetItemAttribute(api.URL);
            Console.WriteLine(r.Name);
            foreach (var e in r.Names) {
                Console.WriteLine($"{e.Language.Name} - {e.Name}");
            }
            Console.WriteLine();
        }
#else
       KAPIResourceList apiList = KPokeAPI.GetEvolutionChains();
        foreach (KAPIResource api in apiList.Results) {
            KEvolutionChain r = KEvolutionChain.GetEvolutionChain(api.URL);
            Console.WriteLine(r.Chain.Species.Name);
        }
 #endif
    }
}

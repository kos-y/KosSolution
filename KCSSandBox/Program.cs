using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
#if true
        KNamedAPIResourceList apiList = KPokeAPI.GetGenerations();
        foreach (KNamedAPIResource api in apiList.Results) {
            KGeneration r = KGeneration.GetGeneration(api.URL);
            Console.WriteLine(r.Name);
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

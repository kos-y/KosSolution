using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
#if false
        KNamedAPIResourceList apiList = KPokeAPI.GetEncounterConditionValues();
        foreach (KNamedAPIResource api in apiList.Results) {
            KEncounterConditionValue r = KEncounterConditionValue.GetEncountConditionValue(api.URL);
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

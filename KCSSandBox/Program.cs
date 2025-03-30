using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetEncounterConditions();
        foreach (KNamedAPIResource api in apiList.Results) {
            KEncounterCondition r = KEncounterCondition.GetEncountCondition(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetEncounterConditionValues();
        foreach (KNamedAPIResource api in apiList.Results) {
            KEncounterConditionValue r = KEncounterConditionValue.GetEncountConditionValue(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

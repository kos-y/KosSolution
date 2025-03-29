using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetEncounterMethods();
        foreach (KNamedAPIResource api in apiList.Results) {
            KEncounterMethod r = KEncounterMethod.GetEncountMethod(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

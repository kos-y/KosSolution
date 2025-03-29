using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList apiList = KPokeAPI.GetContestTypes();
        foreach (KNamedAPIResource api in apiList.Results) {
            KContestType r = KContestType.GetContestType(api.URL);
            Console.WriteLine(r.Name);
        }
    }
}

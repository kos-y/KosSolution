using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KAPIResourceList apiList = KPokeAPI.GetSuperContestEffect();
        foreach (KAPIResource api in apiList.Results) {
            KSuperContestEffect r = KSuperContestEffect.GetSuperContestEffect(api.URL);
            Console.WriteLine(r.FlavorTextEntries.First().FlavorText);
        }
    }
}

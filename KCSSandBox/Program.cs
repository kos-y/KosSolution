using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KAPIResourceList apiList = KPokeAPI.GetContestEffect();
        foreach (KAPIResource api in apiList.Results) {
            KContestEffect r = KContestEffect.GetContestEffect(api.URL);
            Console.WriteLine(r.EffectEntries.First().Effect);
        }
    }
}

using System.Runtime.Versioning;
using System.Linq;
using KCSPokeAPI;

namespace KCSSandBox;

internal class Program
{
    static void Main()
    {
        KNamedAPIResourceList langs = KPokeAPI.GetLanguages();
        foreach (KNamedAPIResource r in langs.Results) {
            Console.WriteLine(r.Name);
        }
    }
}

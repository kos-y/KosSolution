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
            KLanguage lang = KLanguage.GetLanguage(r.URL);
            Console.WriteLine(lang.Name);
        }
    }
}

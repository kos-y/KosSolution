using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみの味のつよさ
/// </summary>
public class KFlavorBerryMap
{
    /// <summary>
    /// 味の強さ
    /// </summary>
    public int Potency { get; set; }

    /// <summary>
    /// 味
    /// </summary>
    public KNamedAPIResource Flavor { get; set; } = new();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 名前付きAPIリソース
/// </summary>
public class KNamedAPIResource
{
    /// <summary>
    /// リソース名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// URL
    /// </summary>
    public string URL { get; set; } = string.Empty;
}

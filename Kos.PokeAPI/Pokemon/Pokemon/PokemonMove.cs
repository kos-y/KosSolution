using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモンの技
/// </summary>
public class PokemonMove
{
    #region 技
    /// <summary>
    /// 技
    /// </summary>
    [JsonPropertyName("move")]
    [DisplayName("move")]
    [Category("(基本)")]
    [Description("技")]
    public NamedAPIResource? Move { get; set; }
    #endregion

    #region バージョンごとの詳細
    /// <summary>
    /// バージョンごとの詳細
    /// </summary>
    [JsonPropertyName("version_group_details")]
    [DisplayName("version_group_details")]
    [Category("(基本)")]
    [Description("バージョンごとの詳細")]
    public IReadOnlyList<PokemonMoveVersion>? VersionGroupDetails { get; set; }
    #endregion
}

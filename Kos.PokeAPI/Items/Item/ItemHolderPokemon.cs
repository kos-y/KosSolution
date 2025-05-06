using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム保持ポケモン
/// </summary>
public class ItemHolderPokemon
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region 詳細リスト
    /// <summary>
    /// 詳細リスト
    /// </summary>
    [JsonPropertyName("version_details")]
    public List<ItemHolderPokemonVersionDetail>? VersionDetails { get; set; }
    #endregion
}

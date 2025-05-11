using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム保持ポケモン
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ItemHolderPokemon
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("(基本)")]
    [Description("ポケモン")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region 詳細リスト
    /// <summary>
    /// 詳細リスト
    /// </summary>
    [JsonPropertyName("version_details")]
    [DisplayName("version_details")]
    [Category("(基本)")]
    [Description("詳細リスト")]
    [TypeConverter(typeof(ListConverter<ItemHolderPokemonVersionDetail>))]
    public IReadOnlyList<ItemHolderPokemonVersionDetail>? VersionDetails { get; set; }
    #endregion
}

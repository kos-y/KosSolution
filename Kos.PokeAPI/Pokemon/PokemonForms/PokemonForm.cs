using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Pokemon.Pokemon;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonForms;

/// <summary>
/// ポケモン フォルム
/// </summary>
public class PokemonForm
{
    #region ポケモン フォルムID
    /// <summary>
    /// ポケモン フォルムID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ポケモン フォルム")]
    [Description("ポケモン フォルムID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモン フォルムの名前
    /// <summary>
    /// ポケモン フォルムの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ポケモン フォルム")]
    [Description("ポケモン フォルムの名前")]
    public string? Name { get; set; }
    #endregion

    #region 順番
    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    [DisplayName("order")]
    [Category("ポケモン フォルム")]
    [Description("順番")]
    public int? Order { get; set; }
    #endregion

    #region フォルム順番
    /// <summary>
    /// フォルム順番
    /// </summary>
    [JsonPropertyName("form_order")]
    [DisplayName("form_order")]
    [Category("ポケモン フォルム")]
    [Description("フォルム順番")]
    public int? FormOrder { get; set; }
    #endregion

    #region デフォルトのフォルムか
    /// <summary>
    /// デフォルトのフォルムか？
    /// </summary>
    [JsonPropertyName("is_default")]
    [DisplayName("is_default")]
    [Category("ポケモン フォルム")]
    [Description("デフォルトのフォルムか")]
    public bool? IsDefault { get; set; }
    #endregion

    #region 戦闘時のみか
    /// <summary>
    /// 戦闘時のみか
    /// </summary>
    [JsonPropertyName("is_battle_only")]
    [DisplayName("is_battle_only")]
    [Category("ポケモン フォルム")]
    [Description("戦闘時のみか")]
    public bool? IsBattleOnly { get; set; }
    #endregion

    #region メガシンカか
    /// <summary>
    /// メガシンカか
    /// </summary>
    [JsonPropertyName("is_mega")]
    [DisplayName("is_mega")]
    [Category("ポケモン フォルム")]
    [Description("メガシンカか")]
    public bool? IsMega { get; set; }
    #endregion

    #region フォルムの名前
    /// <summary>
    /// フォルムの名前
    /// </summary>
    [JsonPropertyName("form_name")]
    [DisplayName("form_name")]
    [Category("ポケモン フォルム")]
    [Description("フォルムの名前")]
    public string? FormName { get; set; }
    #endregion

    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("ポケモン フォルム")]
    [Description("ポケモン")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region フォルムのタイプリスト
    /// <summary>
    /// フォルムのタイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    [DisplayName("types")]
    [Category("ポケモン フォルム")]
    [Description("フォルムのタイプリスト")]
    public IReadOnlyList<PokemonFormType>? Types { get; set; }
    #endregion

    #region スプライト
    /// <summary>
    /// スプライト
    /// </summary>
    [JsonPropertyName("sprites")]
    [DisplayName("sprites")]
    [Category("ポケモン フォルム")]
    [Description("スプライト")]
    public PokemonFormSprites? Sprites { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("ポケモン フォルム")]
    [Description("バージョングループ")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("ポケモン フォルム")]
    [Description("言語との名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region 言語ごとのフォルムの名前リスト
    /// <summary>
    /// 言語ごとのフォルムの名前リスト
    /// </summary>
    [JsonPropertyName("forms_names")]
    [DisplayName("forms_names")]
    [Category("ポケモン フォルム")]
    [Description("言語ごとのフォルムの名前リスト")]
    public IReadOnlyList<Name>? FormsNames { get; set; }
    #endregion
}

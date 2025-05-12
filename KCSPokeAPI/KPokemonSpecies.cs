using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン種族
/// </summary>
public class KPokemonSpecies
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 順番
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// メスになる確率
    /// </summary>
    public int GenderRate { get; set; }

    /// <summary>
    /// 捕獲率
    /// </summary>
    public int CaptureRate { get; set; }

    /// <summary>
    /// 基本なつき度
    /// </summary>
    public int BaseHappiness { get; set; }

    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    public bool IsBaby { get; set; }

    /// <summary>
    /// 伝説ポケモンか
    /// </summary>
    public bool IsLegendary { get; set; }

    /// <summary>
    /// 幻ポケモンか
    /// </summary>
    public bool IsMythical { get; set; }

    /// <summary>
    /// 孵化するまでに必要なサイクル数
    /// </summary>
    public int HatchCounter { get; set; }

    /// <summary>
    /// 性別によって見た目が変わるか
    /// </summary>
    public bool HasGenderDifferences { get; set; }

    /// <summary>
    /// ゲーム内でフォーム変更が可能か
    /// </summary>
    public bool HasFormsSwitchable { get; set; }

    /// <summary>
    /// 成長速度
    /// </summary>
    public KNamedAPIResource GrowthRate { get; set; }

    /// <summary>
    /// ポケモン図鑑番号リスト
    /// </summary>
    public List<KPokemonSpeciesDexEntry> PokedexNumbers { get; set; } = [];

    /// <summary>
    /// 卵グループリスト
    /// </summary>
    public List<KNamedAPIResource> EggGroups { get; set; } = [];

    /// <summary>
    /// 色
    /// </summary>
    public KNamedAPIResource Color { get; set; }

    /// <summary>
    /// 形状
    /// </summary>
    public KNamedAPIResource Shape { get; set; }

    /// <summary>
    /// 進化元
    /// </summary>
    public KNamedAPIResource EvolvesFromSpecies { get; set; }

    /// <summary>
    /// 進化チェーン
    /// </summary>
    public KNamedAPIResource EvolutionChain { get; set; }

    /// <summary>
    /// 生息地
    /// </summary>
    public KNamedAPIResource Habitat { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; }

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// パルパーク エンカウント リスト
    /// </summary>
   // public List<KPalParkEncounterArea> PalParkEncounter { get; set; } = [];

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<KFlavorText> FlavorTextEntries { get; set; } = [];

    /// <summary>
    /// フォームの説明リスト
    /// </summary>
    public List<KDescription> FormDescriptions { get; set; } = [];

    /// <summary>
    /// 〇〇ポケモン
    /// </summary>
    public List<KGenus> genera { get; set; } = [];

    /// <summary>
    /// バリエーション
    /// </summary>
    public List<KPokemonSpeciesVariety> Varieties { get; set; } = [];
}

using System.Reflection;
using Kos.PokeAPI;
using Kos.PokeAPI.Attribute;
using Kos.PokeAPI.Forms;
using Kos.PokeAPI.Forms.Utility.Languages;
using Kos.PokeAPI.ResourceLists;
using Kos.PokeAPI.Utility.CommonModels;

namespace AppPokeAPIViewer;

/// <summary>
/// PokeAPI Viewer
/// </summary>
public partial class PokeAPIViewer : Form
{
    // フィールド

    #region 子フォームリスト
    /// <summary>
    /// 子フォームリスト
    /// </summary>
    private readonly List<Form> _childFormList = [];
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PokeAPIViewer()
    {
        InitializeComponent();
    }
    #endregion

    #region Form Load
    /// <summary>
    /// Form Load
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void PokeAPIViewer_Load(object sender, EventArgs e)
    {
        // リソースカテゴリの表示
        SetResourceCategory(ResourceCategoryListBox);
    }
    #endregion

    #region FormClosing
    /// <summary>
    /// FormClosing
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void PokeAPIViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
        _childFormList.ForEach(form => form.Dispose());
    }
    #endregion

    #region リソースカテゴリリスト 選択変更
    /// <summary>
    /// リソースカテゴリリスト 選択変更
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void ResourceCategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        object? item = ResourceCategoryListBox.SelectedItem;
        if (item is null) {
            return;
        }

        if (item is not ResourceCategoryAttribute attr) {
            return;
        }

        SetEndPoint(attr, EndPointListBox);
    }
    #endregion

    #region エンドポイントリスト ダブルクリック
    /// <summary>
    /// エンドポイントリスト ダブルクリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void EndPointListBox_DoubleClick(object sender, EventArgs e)
    {
        object? item = EndPointListBox?.SelectedItem;
        if (item is null) {
            return;
        }

        if (item is not EndPointAttribute attr) {
            return;
        }

        Form? form = GetListForm(attr);
        if (form is null) {
            return;
        }

        form.Show(this);
        _childFormList.Add(form);
    }
    #endregion

    #region Open クリック
    /// <summary>
    /// Open クリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void OpenButton_Click(object sender, EventArgs e)
    {
        object? item = EndPointListBox?.SelectedItem;
        if (item is null) {
            return;
        }

        if (item is not EndPointAttribute attr) {
            return;
        }

        Form? form = GetListForm(attr);
        if (form is null) {
            return;
        }

        form.Show(this);
        _childFormList.Add(form);
    }
    #endregion

    #region Close クリック
    /// <summary>
    /// Close クリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion


    // 静的メソッド

    #region リソースカテゴリの表示
    /// <summary>
    /// リソースカテゴリの表示
    /// </summary>
    /// <param name="rclb">リソースカテゴリリストボックス</param>
    private static void SetResourceCategory(ListBox rclb)
    {
        Type type = typeof(ResourceCategory);

        foreach (ResourceCategory rc in Enum.GetValues(typeof(ResourceCategory))) {
            FieldInfo? fi = type.GetField(rc.ToString());
            if (fi is null) {
                continue;
            }

            ResourceCategoryAttribute? attr = fi.GetCustomAttribute<ResourceCategoryAttribute>();
            if (attr is null) {
                continue;
            }

            _ = rclb.Items.Add(attr);
        }
    }
    #endregion

    #region エンドポイントの表示
    /// <summary>
    /// エンドポイントの表示
    /// </summary>
    /// <param name="eca">リソースカテゴリのAttribute</param>
    /// <param name="eplb">エンドポイントリストボックス</param>
    private static void SetEndPoint(ResourceCategoryAttribute eca, ListBox eplb)
    {
        Type type = typeof(EndPoint);

        eplb.ClearSelected();
        eplb.Items.Clear();
        foreach (EndPoint ep in eca.EndPoints) {
            FieldInfo? fi = type.GetField(ep.ToString());
            if (fi is null) {
                continue;
            }

            EndPointAttribute? attr = fi.GetCustomAttribute<EndPointAttribute>();
            if (attr is null) {
                continue;
            }

            _ = eplb.Items.Add(attr);
        }
    }
    #endregion

    #region エンドポイントに合わせたListFormの取得
    /// <summary>
    /// エンドポイントに合わせたListFormの取得
    /// </summary>
    /// <param name="eca">エンドポイントAttribute</param>
    /// <returns>ListForm</returns>
    private static Form? GetListForm(EndPointAttribute eca)
    {
        return eca.Name switch {
            nameof(EndPoint.Berries) =>
                new NamedAPIResourceListForm(eca, typeof(BerryInfoForm)),

            nameof(EndPoint.BerryFirmnesses) =>
                new NamedAPIResourceListForm(eca, typeof(BerryFirmnessInfoForm)),

            nameof(EndPoint.BerryFlavors) =>
                new NamedAPIResourceListForm(eca, typeof(BerryFlavorInfoForm)),

            nameof(EndPoint.ContestTypes) =>
                new NamedAPIResourceListForm(eca, typeof(ContestTypeInfoForm)),

            nameof(EndPoint.ContestEffects) =>
                new APIResourceListForm(eca, typeof(ContestEffectInfoForm)),

            nameof(EndPoint.SuperContestEffects) =>
                new APIResourceListForm(eca, typeof(SuperContestEffectInfoForm)),

            nameof(EndPoint.EncounterMethods) =>
                new NamedAPIResourceListForm(eca, typeof(EncounterMethodInfoForm)),

            nameof(EndPoint.EncounterConditions) =>
                new NamedAPIResourceListForm(eca, typeof(EncounterConditionInfoForm)),

            nameof(EndPoint.EncounterConditionValues) =>
                new NamedAPIResourceListForm(eca, typeof(EncounterConditionValueInfoForm)),

            nameof(EndPoint.EvolutionChains) =>
                new APIResourceListForm(eca, typeof(EvolutionChainInfoForm)),

            nameof(EndPoint.EvolutionTriggers) =>
                new NamedAPIResourceListForm(eca, typeof(EvolutionTriggerInfoForm)),

            nameof(EndPoint.Generations) =>
                new NamedAPIResourceListForm(eca, typeof(GenerationInfoForm)),

            nameof(EndPoint.Pokedexes) =>
                new NamedAPIResourceListForm(eca, typeof(PokedexInfoForm)),

            nameof(EndPoint.Version) =>
                new NamedAPIResourceListForm(eca, typeof(VersionInfoForm)),

            nameof(EndPoint.Languages) =>
                new NamedAPIResourceListForm(eca, typeof(LanguageInfoForm)),

            nameof(EndPoint.VersionGroups) =>
                new NamedAPIResourceListForm(eca, typeof(VersionGroupInfoForm)),

            nameof(EndPoint.Item) =>
                new NamedAPIResourceListForm(eca, typeof(ItemInfoForm)),

            nameof(EndPoint.ItemAttributes) =>
                new NamedAPIResourceListForm(eca, typeof(ItemAttributeInfoForm)),

            nameof(EndPoint.ItemCategories) =>
                new NamedAPIResourceListForm(eca, typeof(ItemCategoryInfoForm)),

            nameof(EndPoint.ItemFlingEffects) =>
                new NamedAPIResourceListForm(eca, typeof(ItemFlingEffectInfoForm)),

            nameof(EndPoint.ItemPockets) =>
                new NamedAPIResourceListForm(eca, typeof(ItemPocketInfoForm)),

            nameof(EndPoint.Locations) =>
                new NamedAPIResourceListForm(eca, typeof(LocationInfoForm)),

            nameof(EndPoint.LocationAreas) =>
                new NamedAPIResourceListForm(eca, typeof(LocationAreaInfoForm)),

            nameof(EndPoint.PalParkAreas) =>
                new NamedAPIResourceListForm(eca, typeof(PalParkAreaInfoForm)),

            nameof(EndPoint.Regions) =>
                new NamedAPIResourceListForm(eca, typeof(RegionInfoForm)),

            nameof(EndPoint.Machines) =>
                new APIResourceListForm(eca, typeof(MachineInfoForm)),

            nameof(EndPoint.Moves) =>
                new NamedAPIResourceListForm(eca, typeof(MoveInfoForm)),

            nameof(EndPoint.MoveAilments) =>
                new NamedAPIResourceListForm(eca, typeof(MoveAilmentInfoForm)),

            nameof(EndPoint.MoveBattleStyles) =>
                new NamedAPIResourceListForm(eca, typeof(MoveBattleStyleInfoForm)),

            nameof(EndPoint.MoveCategories) =>
                new NamedAPIResourceListForm(eca, typeof(MoveCategoryInfoForm)),

            nameof(EndPoint.MoveDamageClasses) =>
                new NamedAPIResourceListForm(eca, typeof(MoveDamageClassInfoForm)),

            nameof(EndPoint.MoveLearnMethods) =>
                new NamedAPIResourceListForm(eca, typeof(MoveLearnMethodInfoForm)),

            nameof(EndPoint.MoveTargets) =>
                new NamedAPIResourceListForm(eca, typeof(MoveTargetInfoForm)),

            nameof(EndPoint.Abilities) =>
                new NamedAPIResourceListForm(eca, typeof(AbilityInfoForm)),

            nameof(EndPoint.Characteristics) =>
                new APIResourceListForm(eca, typeof(CharacteristicInfoForm)),

            nameof(EndPoint.EggGroups) =>
                new NamedAPIResourceListForm(eca, typeof(EggGroupInfoForm)),

            nameof(EndPoint.Genders) =>
                new NamedAPIResourceListForm(eca, typeof(GenderInfoForm)),

            nameof(EndPoint.GrowthRates) =>
                new NamedAPIResourceListForm(eca, typeof(GrowthRateInfoForm)),

            nameof(EndPoint.Natures) =>
                new NamedAPIResourceListForm(eca, typeof(NatureInfoForm)),

            nameof(EndPoint.PokeathlonStats) =>
                new NamedAPIResourceListForm(eca, typeof(PokeathlonStatInfoForm)),

            nameof(EndPoint.Pokemon) =>
                new NamedAPIResourceListForm(eca, typeof(PokemonInfoForm)),

            _ => null,
        };
    }
    #endregion
}

using Kos.Core.WPF;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Utility.WPF.Languages;

/// <summary>
/// 言語 ViewModel
/// </summary>
public class LanguageViewModel : NotifyPropertyChanged
{
    // フィールド

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    private Language _language;
    #endregion

    #region ID
    /// <summary>
    /// ID
    /// </summary>
    public int? Id => _language.Id;
    #endregion

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    public string? Name => _language.Name;
    #endregion

    #region 対応言語か
    /// <summary>
    /// 対応言語か
    /// </summary>
    public bool? Official => _language.Official;
    #endregion

    #region ISO639コード
    /// <summary>
    /// ISO639コード
    /// </summary>
    public string? Iso639 => _language.Iso639;
    #endregion

    #region ISO3166コード
    /// <summary>
    /// ISO3166コード
    /// </summary>
    public string? Iso3166 => _language.Iso3166;
    #endregion
}


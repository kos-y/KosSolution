using Kos.Core.WPF;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Utility.WPF.Languages;

/// <summary>
/// ���� ViewModel
/// </summary>
public class LanguageViewModel : NotifyPropertyChanged
{
    // �t�B�[���h

    #region ����
    /// <summary>
    /// ����
    /// </summary>
    private Language _language;
    #endregion

    #region ID
    /// <summary>
    /// ID
    /// </summary>
    public int? Id => _language.Id;
    #endregion

    #region ���O
    /// <summary>
    /// ���O
    /// </summary>
    public string? Name => _language.Name;
    #endregion

    #region �Ή����ꂩ
    /// <summary>
    /// �Ή����ꂩ
    /// </summary>
    public bool? Official => _language.Official;
    #endregion

    #region ISO639�R�[�h
    /// <summary>
    /// ISO639�R�[�h
    /// </summary>
    public string? Iso639 => _language.Iso639;
    #endregion

    #region ISO3166�R�[�h
    /// <summary>
    /// ISO3166�R�[�h
    /// </summary>
    public string? Iso3166 => _language.Iso3166;
    #endregion
}


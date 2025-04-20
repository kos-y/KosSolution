using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.Core.WPF;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Utility.WPF.CommonModels;

/// <summary>
/// Name ViewModel
/// </summary>
public class NameViewModel : NotifyPropertyChanged
{
    // フィールド

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    private readonly Name _name;
    #endregion

    #region 言語リソース ViewModel
    /// <summary>
    /// 言語リソース ViewModel
    /// </summary>
    private NamedAPIResourceViewModel? _languageViewModel = null;
    #endregion

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    public string Name => !string.IsNullOrWhiteSpace(_name.Text) ? _name.Text : string.Empty;
    #endregion

    #region 言語リソース ViewModel
    /// <summary>
    /// 言語リソース ViewModel
    /// </summary>
    public NamedAPIResourceViewModel? Language
    {
        get {
            if (_languageViewModel is null) {
                if (_name.Language is not null) {
                    _languageViewModel = new(_name.Language);
                }
            }

            return _languageViewModel;
        }
    }
    #endregion
}

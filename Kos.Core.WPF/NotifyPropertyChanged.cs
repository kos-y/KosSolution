using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kos.Core.WPF;

/// <summary>
/// プロパティ変更通知
/// </summary>
public class NotifyPropertyChanged : INotifyPropertyChanged
{
    // フィールド

    #region イベントハンドラ PropertyChanged
    /// <summary>
    /// イベントハンドラ PropertyChanged
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion


    // メソッド

    #region プロパティ変更通知実行
    /// <summary>
    /// プロパティ変更通知実行
    /// </summary>
    /// <param name="propertyName">プロパティ名</param>
    protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChangedEventArgs args = new(propertyName);

        PropertyChanged?.Invoke(this, args);
    }
    #endregion
}


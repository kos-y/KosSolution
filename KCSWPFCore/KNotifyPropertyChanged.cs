
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KCSWPFCore;

/// <summary>
/// プロパティ変更通知
/// </summary>
public class KNotifyPropertyChanged : INotifyPropertyChanged
{
    /// <summary>
    /// PropertyChanged イベントハンドラ
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// プロパティ変更通知実行
    /// </summary>
    /// <param name="propertyName">プロパティ名</param>
    protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChangedEventArgs args = new(propertyName);

        PropertyChanged?.Invoke(this, args);
    }
}


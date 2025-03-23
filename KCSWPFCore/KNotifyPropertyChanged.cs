
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KCSWPFCore;

/// <summary>
/// �v���p�e�B�ύX�ʒm
/// </summary>
public class KNotifyPropertyChanged : INotifyPropertyChanged
{
    /// <summary>
    /// PropertyChanged �C�x���g�n���h��
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// �v���p�e�B�ύX�ʒm���s
    /// </summary>
    /// <param name="propertyName">�v���p�e�B��</param>
    protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChangedEventArgs args = new(propertyName);

        PropertyChanged?.Invoke(this, args);
    }
}


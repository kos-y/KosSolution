using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kos.Core.WPF;

/// <summary>
/// �v���p�e�B�ύX�ʒm
/// </summary>
public class NotifyPropertyChanged : INotifyPropertyChanged
{
    // �t�B�[���h

    #region �C�x���g�n���h�� PropertyChanged
    /// <summary>
    /// �C�x���g�n���h�� PropertyChanged
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion


    // ���\�b�h

    #region �v���p�e�B�ύX�ʒm���s
    /// <summary>
    /// �v���p�e�B�ύX�ʒm���s
    /// </summary>
    /// <param name="propertyName">�v���p�e�B��</param>
    protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChangedEventArgs args = new(propertyName);

        PropertyChanged?.Invoke(this, args);
    }
    #endregion
}


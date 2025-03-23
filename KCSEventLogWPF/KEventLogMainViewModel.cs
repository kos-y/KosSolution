
using System.Collections.ObjectModel;
using System.Windows.Input;
using KCSEventLog;
using KCSWPFCore;

namespace KCSEventLogWPF;

/// <summary>
/// �C�x���g���O ���C�� ViewModel
/// </summary>
public class KEventLogMainViewModel : KNotifyPropertyChanged
{
    /// <summary>
    /// ���[�J���R���s���[�^�[���炢�ك��O���擾����R�}���h
    /// </summary>
    public ICommand GetEventLogsLocalComputerCommand { get; set; }

    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�R���N�V����
    /// </summary>
    public ObservableCollection<KEventLog> EventLogs { get; } = [];

    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�G���g���R���N�V����
    /// </summary>
    public ObservableCollection<KEventLogEntry> EventLogEntries { get; } = [];


    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    public KEventLogMainViewModel()
    {
        GetEventLogsLocalComputerCommand = new KGetEventLogsLocalComputerCommand(this);
    }

    /// <summary>
    /// �C�x���g���O�ύX���̏���
    /// </summary>
    /// <param name="eventLog">�C�x���g���O</param>
    public void SelectionChangeEventLog(KEventLog eventLog)
    {
        EventLogEntries.Clear();
        foreach (KEventLogEntry entry in eventLog.Entries) {
            EventLogEntries.Add(entry);
        }

        RaisePropertyChanged(nameof(EventLogEntries));
    }
}


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
    /// ���[�J���R���s���[�^�[����C�x���g���O���擾����R�}���h
    /// </summary>
    public KCommand GetEventLogsLocalComputerCommand { get; set; }

    /// <summary>
    /// �C�x���g���O�̑I��ύX�R�}���h
    /// </summary>
    public KCommand EventLogSelectionChangedCommand { get; set; }

    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�R���N�V����
    /// </summary>
    public ObservableCollection<KEventLog> EventLogs { get; } = [];

    /// <summary>
    /// �I�𒆂̃C�x���g���O
    /// </summary>
    public KEventLog? SelectedEventLog { get; set; } = null;

    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�G���g���R���N�V����
    /// </summary>
    public ObservableCollection<KEventLogEntry> EventLogEntries { get; } = [];


    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    public KEventLogMainViewModel()
    {
        GetEventLogsLocalComputerCommand = new KCommand(GetEventLogsLocalComputer);
        EventLogSelectionChangedCommand = new KCommand(SelectionChangeEventLog);
    }

    /// <summary>
    /// �C�x���g���O�����[�J���R���s���[�^�[����擾
    /// </summary>
    private void GetEventLogsLocalComputer()
    {
        IEnumerable<KEventLog> eventLogs = KEventLog.GetEventLogsLocalComputer();

        EventLogs.Clear();
        foreach (KEventLog eventLog in eventLogs) {
            EventLogs.Add(eventLog);
        }
    }

    /// <summary>
    /// �C�x���g���O�ύX���̏���
    /// </summary>
    private void SelectionChangeEventLog()
    {
        if (SelectedEventLog is null)
        {
            return;
        }

        EventLogEntries.Clear();
        foreach (KEventLogEntry entry in SelectedEventLog.Entries) {
            EventLogEntries.Add(entry);
        }

        RaisePropertyChanged(nameof(EventLogEntries));
    }
}

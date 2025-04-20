using System.Collections.ObjectModel;
using Kos.Core.WPF;

namespace Kos.EventLog.WPF;

public class EventLogViewModel : NotifyPropertyChanged
{
    // �t�B�[���h

    #region �C�x���g���O ObservableCollection
    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�R���N�V����
    /// </summary>
    public ObservableCollection<EventLog> EventLogs { get; } = [];
    #endregion

    #region �I�𒆃C�x���g���O
    /// <summary>
    /// �I�𒆂̃C�x���g���O
    /// </summary>
    public EventLog? SelectedEventLog { get; set; } = null;
    #endregion

    #region �C�x���g���O�G���g���[ ObservableCollection
    /// <summary>
    /// �R���s���[�^�[����擾�����C�x���g���O�G���g���[�R���N�V����
    /// </summary>
    public ObservableCollection<EventLogEntry> EventLogEntries { get; } = [];
    #endregion


    // �R�}���h

    #region �C�x���g���O�擾 ���[�J���R���s���[�^�[
    /// <summary>
    /// �C�x���g���O�擾 ���[�J���R���s���[�^�[
    /// </summary>
    public Command GetEventLogLocalComputerCommand { get; set; }
    #endregion

    #region �I��ύX �C�x���g���O
    /// <summary>
    /// �I��ύX �C�x���g���O
    /// </summary>
    public Command EventLoSelectionChangedCommand { get; set; }
    #endregion


    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    public EventLogViewModel()
    {
        GetEventLogLocalComputerCommand = new Command(GetEventLogLocalComputer);
        EventLoSelectionChangedCommand = new Command(SelectionChangeEventLog);
    }
    #endregion

    #region �C�x���g���O�擾 ���[�J���R���s���[�^�[
    /// <summary>
    /// �C�x���g���O�����[�J���R���s���[�^�[����擾
    /// </summary>
    private void GetEventLogLocalComputer()
    {
        IEnumerable<EventLog> eventLogs = EventLog.GetEventLogsLocalComputer();

        EventLogs.Clear();
        foreach (EventLog eventLog in eventLogs) {
            EventLogs.Add(eventLog);
        }
    }
    #endregion

    #region �I��ύX �C�x���g���O
    /// <summary>
    /// �C�x���g���O�ύX���̏���
    /// </summary>
    private void SelectionChangeEventLog()
    {
        if (SelectedEventLog is null) {
            return;
        }

        EventLogEntries.Clear();
        foreach (EventLogEntry entry in SelectedEventLog.Entries) {
            EventLogEntries.Add(entry);
        }

        RaisePropertyChanged(nameof(EventLogEntries));
    }
    #endregion
}


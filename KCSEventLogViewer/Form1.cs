using KCSEventLog;

namespace KCSEventLogViewer;

public partial class Form1 : Form
{
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// �{�^���N���b�N�C�x���g
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonClickEvent(object sender, EventArgs e)
    {
        if (sender is not Button button) {
            return;
        }

        switch (button.Name) {
        case nameof(_btnLocalComputer):
            // ���[�J���R���s���[�^�[
            GetEventLogsLocalComputer();
            break;

        default:
            break;
        }
    }

    /// <summary>
    /// ���X�g�{�b�N�X �I��Index�ύX�C�x���g
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender is not ListBox listBox) {
            return;
        }

        switch (listBox.Name) {
        case nameof(_lbEventLog):
            SetEventEntries();
            break;

        default:
            break;
        }
    }

    /// <summary>
    /// ���[�J���R���s���[�^�[����C�x���g���O���擾����
    /// </summary>
    private void GetEventLogsLocalComputer()
    {
        IEnumerable<KEventLog> eventLogs = KEventLog.GetEventLogsLocalComputer();

        foreach (KEventLog eventLog in eventLogs) {
            _lbEventLog.Items.Add(new EventLogListItem(eventLog));
        }
    }

    /// <summary>
    /// �C�x���g���O�G���g���[�Ƀf�[�^�̐ݒ�
    /// </summary>
    private void SetEventEntries()
    {
        if (_lbEventLog.SelectedItem is not EventLogListItem item) {
            return;
        }

        _dgvEventLogEntries.DataSource = item.EventLog.Entries;
    }
}

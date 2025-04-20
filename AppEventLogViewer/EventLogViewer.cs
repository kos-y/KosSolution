using Kos.EventLog;

namespace AppEventLogViewer;

/// <summary>
/// �C�x���g���O �r���[�A�[
/// </summary>
public partial class EventLogViewer : Form
{
    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    public EventLogViewer()
    {
        InitializeComponent();
    }
    #endregion

    #region �u���[�J���R���s���[�^�[�v�{�^�� �N���b�N
    /// <summary>
    /// �u���[�J���R���s���[�^�[�v�{�^�� �N���b�N
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
    private void LocalComputerButton_Click(object sender, EventArgs e)
    {
        foreach (EventLog eventLog in EventLog.GetEventLogsLocalComputer()) {
            _ = EventLogListBox.Items.Add(new EventLogItem(eventLog));
        }
    }
    #endregion

    #region �C�x���g���O���X�g�{�b�N�X �I��ύX
    /// <summary>
    /// �C�x���g���O���X�g�{�b�N�X �I��ύX
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
    private void EventLogListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (EventLogListBox.SelectedItem is not EventLogItem eventLog) {
            return;
        }

        EventLogEntriesDataGridView.DataSource = eventLog.EventLog.Entries;
    }
    #endregion

}

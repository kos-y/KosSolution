using Kos.EventLog;

namespace AppEventLogViewer;

/// <summary>
/// イベントログ ビューアー
/// </summary>
public partial class EventLogViewer : Form
{
    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EventLogViewer()
    {
        InitializeComponent();
    }
    #endregion

    #region 「ローカルコンピューター」ボタン クリック
    /// <summary>
    /// 「ローカルコンピューター」ボタン クリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void LocalComputerButton_Click(object sender, EventArgs e)
    {
        foreach (EventLog eventLog in EventLog.GetEventLogsLocalComputer()) {
            _ = EventLogListBox.Items.Add(new EventLogItem(eventLog));
        }
    }
    #endregion

    #region イベントログリストボックス 選択変更
    /// <summary>
    /// イベントログリストボックス 選択変更
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void EventLogListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (EventLogListBox.SelectedItem is not EventLogItem eventLog) {
            return;
        }

        EventLogEntriesDataGridView.DataSource = eventLog.EventLog.Entries;
    }
    #endregion

}

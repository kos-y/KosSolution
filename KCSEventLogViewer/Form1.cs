using KCSEventLog;

namespace KCSEventLogViewer;

public partial class Form1 : Form
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// ボタンクリックイベント
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
            // ローカルコンピューター
            GetEventLogsLocalComputer();
            break;

        default:
            break;
        }
    }

    /// <summary>
    /// リストボックス 選択中Index変更イベント
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
    /// ローカルコンピューターからイベントログを取得する
    /// </summary>
    private void GetEventLogsLocalComputer()
    {
        IEnumerable<KEventLog> eventLogs = KEventLog.GetEventLogsLocalComputer();

        foreach (KEventLog eventLog in eventLogs) {
            _lbEventLog.Items.Add(new EventLogListItem(eventLog));
        }
    }

    /// <summary>
    /// イベントログエントリーにデータの設定
    /// </summary>
    private void SetEventEntries()
    {
        if (_lbEventLog.SelectedItem is not EventLogListItem item) {
            return;
        }

        _dgvEventLogEntries.DataSource = item.EventLog.Entries;
    }
}

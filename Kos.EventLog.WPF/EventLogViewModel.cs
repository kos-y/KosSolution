using System.Collections.ObjectModel;
using Kos.Core.WPF;

namespace Kos.EventLog.WPF;

public class EventLogViewModel : NotifyPropertyChanged
{
    // フィールド

    #region イベントログ ObservableCollection
    /// <summary>
    /// コンピューターから取得したイベントログコレクション
    /// </summary>
    public ObservableCollection<EventLog> EventLogs { get; } = [];
    #endregion

    #region 選択中イベントログ
    /// <summary>
    /// 選択中のイベントログ
    /// </summary>
    public EventLog? SelectedEventLog { get; set; } = null;
    #endregion

    #region イベントログエントリー ObservableCollection
    /// <summary>
    /// コンピューターから取得したイベントログエントリーコレクション
    /// </summary>
    public ObservableCollection<EventLogEntry> EventLogEntries { get; } = [];
    #endregion


    // コマンド

    #region イベントログ取得 ローカルコンピューター
    /// <summary>
    /// イベントログ取得 ローカルコンピューター
    /// </summary>
    public Command GetEventLogLocalComputerCommand { get; set; }
    #endregion

    #region 選択変更 イベントログ
    /// <summary>
    /// 選択変更 イベントログ
    /// </summary>
    public Command EventLoSelectionChangedCommand { get; set; }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EventLogViewModel()
    {
        GetEventLogLocalComputerCommand = new Command(GetEventLogLocalComputer);
        EventLoSelectionChangedCommand = new Command(SelectionChangeEventLog);
    }
    #endregion

    #region イベントログ取得 ローカルコンピューター
    /// <summary>
    /// イベントログをローカルコンピューターから取得
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

    #region 選択変更 イベントログ
    /// <summary>
    /// イベントログ変更時の処理
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


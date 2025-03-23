
using System.Collections.ObjectModel;
using System.Windows.Input;
using KCSEventLog;
using KCSWPFCore;

namespace KCSEventLogWPF;

/// <summary>
/// イベントログ メイン ViewModel
/// </summary>
public class KEventLogMainViewModel : KNotifyPropertyChanged
{
    /// <summary>
    /// ローカルコンピューターからい弁ログを取得するコマンド
    /// </summary>
    public ICommand GetEventLogsLocalComputerCommand { get; set; }

    /// <summary>
    /// コンピューターから取得したイベントログコレクション
    /// </summary>
    public ObservableCollection<KEventLog> EventLogs { get; } = [];

    /// <summary>
    /// コンピューターから取得したイベントログエントリコレクション
    /// </summary>
    public ObservableCollection<KEventLogEntry> EventLogEntries { get; } = [];


    /// <summary>
    /// コンストラクタ
    /// </summary>
    public KEventLogMainViewModel()
    {
        GetEventLogsLocalComputerCommand = new KGetEventLogsLocalComputerCommand(this);
    }

    /// <summary>
    /// イベントログ変更時の処理
    /// </summary>
    /// <param name="eventLog">イベントログ</param>
    public void SelectionChangeEventLog(KEventLog eventLog)
    {
        EventLogEntries.Clear();
        foreach (KEventLogEntry entry in eventLog.Entries) {
            EventLogEntries.Add(entry);
        }

        RaisePropertyChanged(nameof(EventLogEntries));
    }
}

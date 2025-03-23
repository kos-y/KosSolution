
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
    /// イベントログの選択変更コマンド
    /// </summary>
    public KCommand EventLogSelectionChangedCommand { get; set; }

    /// <summary>
    /// コンピューターから取得したイベントログコレクション
    /// </summary>
    public ObservableCollection<KEventLog> EventLogs { get; } = [];

    /// <summary>
    /// 選択中のイベントログ
    /// </summary>
    public KEventLog? SelectedEventLog { get; set; } = null;

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

        EventLogSelectionChangedCommand = new KCommand(SelectionChangeEventLog);
    }

    /// <summary>
    /// イベントログ変更時の処理
    /// </summary>
    public void SelectionChangeEventLog()
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

using KCSEventLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KCSEventLogWPF;

/// <summary>
/// ローカルコンピューター内のイベントログを取得するコマンド
/// </summary>
/// <param name="viewModel"イベントログ ViewModel></param>
public class KGetEventLogsLocalComputerCommand(KEventLogMainViewModel viewModel) : ICommand
{
    /// <summary>
    /// 
    /// </summary>
#pragma warning disable CS0067
    public event EventHandler? CanExecuteChanged;
#pragma warning restore CS0067

    /// <summary>
    /// イベントログ ViewModel
    /// </summary>
    private readonly KEventLogMainViewModel _viewModel = viewModel;

    /// <summary>
    /// コマンド実行可否の判定
    /// </summary>
    /// <param name="_">未使用</param>
    /// <returns>trueのみ</returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool CanExecute(object? _)
    {
        return _viewModel is not null;
    }

    /// <summary>
    /// コマンド実行
    /// </summary>
    /// <param name="_">未使用</param>
    public void Execute(object? _)
    {
        IEnumerable<KEventLog> eventLogs = KEventLog.GetEventLogsLocalComputer();

        _viewModel.EventLogs.Clear();
        foreach (KEventLog eventLog in eventLogs) {
            _viewModel.EventLogs.Add(eventLog);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KCSWPFCore;

/// <summary>
/// コマンド
/// </summary>
public class KCommand : ICommand
{
    /// <summary>
    /// 実行
    /// </summary>
    private readonly Action? _execute;

    /// <summary>
    /// 実行可否判定
    /// </summary>
    private readonly Func<bool>? _canExecute;

    /// <summary>
    /// コマンド実行可否イベントハンドラ
    /// </summary>
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }


    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="execute">コマンド実行Action</param>
    public KCommand(Action execute)
    {
        _execute = execute;
        _canExecute = new Func<bool>(() => true);
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="execute">コマンド実行Action</param>
    /// <param name="canExecute">コマンド実行可否Func</param>
    public KCommand(Action execute, Func<bool> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    /// <summary>
    /// コマンド実行可否判定
    /// </summary>
    /// <param name="_">未使用</param>
    /// <returns>コマンド実行可否</returns>
    public bool CanExecute(object? _)
    {
        if (_canExecute is not null) {
            return _canExecute.Invoke();
        }

        return false;
    }

    /// <summary>
    /// コマンド実行
    /// </summary>
    /// <param name="_">未使用</param>
    public void Execute(object? _) {
        if (_execute is not null) {
            _execute();
        }
}
}

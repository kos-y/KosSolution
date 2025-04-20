using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kos.Core.WPF;

/// <summary>
/// コマンド
/// </summary>
public class Command : ICommand
{
    // フィールド

    #region 実行処理
    /// <summary>
    /// 実行処理
    /// </summary>
    private readonly Action? _execute;
    #endregion

    #region 実行可否判定処理
    /// <summary>
    /// 実行可否判定処理
    /// </summary>
    private readonly Func<bool>? _canExecute;
    #endregion

    #region イベントハンドラ CanExecuteChanged
    /// <summary>
    /// コマンド実行可否イベントハンドラ
    /// </summary>
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="execute">実行処理</param>
    public Command(Action execute)
    {
        _execute = execute;
        _canExecute = new Func<bool>(static () => true);
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="execute">実行処理</param>
    /// <param name="canExecute">実行可否判定処理</param>
    public Command(Action execute, Func<bool> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }
    #endregion

    #region コマンド実行可否判定
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
    #endregion

    #region コマンド実行
    /// <summary>
    /// コマンド実行
    /// </summary>
    /// <param name="_">未使用</param>
    public void Execute(object? _)
    {
        if (_execute is not null) {
            _execute();
        }
    }
    #endregion
}

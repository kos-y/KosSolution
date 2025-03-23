using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログが最大ファイルに達した際の処理
/// </summary>
public enum KEventLogOverflowAction : sbyte
{
    /// <summary>
    /// 既存エントリを残して新規エントリを破棄
    /// </summary>
    DoNotOverwrite = -1,

    /// <summary>
    /// 最古のエントリを新規エントリで上書き
    /// </summary>
    OverwriteAsNeeded = 0,

    /// <summary>
    /// 保持日数を超過したエントリを新規エントリで上書き
    /// 保持日数を超過したエントリがない場合は新規エントリを破棄
    /// </summary>
    OverwriteOlder = 1
}


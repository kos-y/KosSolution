using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログ エントリの種類
/// </summary>
public enum KEventLogEntryType
{
    /// <summary>
    /// エラーイベント
    /// </summary>
    Error = 1,

    /// <summary>
    /// 警告イベント
    /// </summary>
    Warning = 2,

    /// <summary>
    /// 情報イベント
    /// </summary>
    Information = 4,

    /// <summary>
    /// 成功した監査イベント
    /// </summary>
    SuccessAudit = 8,

    /// <summary>
    /// 監査エラーイベント
    /// </summary>
    FailureAudit = 16
}

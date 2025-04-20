using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.EventLog;

namespace AppEventLogViewer;

/// <summary>
/// イベントログ アイテム
/// </summary>
/// <param name="eventLog">イベントログ</param>
public class EventLogItem(EventLog eventLog)
{
    // フィールド

    #region イベントログ
    /// <summary>
    /// イベントログ
    /// </summary>
    public EventLog EventLog { get; private set; } = eventLog;
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return EventLog.LogName;
    }
    #endregion
}

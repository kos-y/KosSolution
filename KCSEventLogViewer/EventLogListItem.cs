using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KCSEventLog;

namespace KCSEventLogViewer;

/// <summary>
/// イベントログリストボックスのアイテム
/// </summary>
/// <param name="eventLog">イベントログ</param>
internal class EventLogListItem(KEventLog eventLog)
{
    /// <summary>
    /// イベントログの実データ
    /// </summary>
    public KEventLog EventLog { get; private set; } = eventLog;

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列化結果</returns>
    public override string ToString()
    {
        return EventLog.LogName;
        ;
    }
}

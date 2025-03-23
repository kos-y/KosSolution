using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログエントリ
/// </summary>
public class KEventLogEntry
{
    /// <summary>
    /// イベントログ エントリ
    /// </summary>
    private EventLogEntry _eventLogEntry;

    /// <summary>
    /// イベントログエントリの種類
    /// </summary>
    [SupportedOSPlatform("windows")]
    public KEventLogEntryType EntryType => (KEventLogEntryType)_eventLogEntry.EntryType;

    /// <summary>
    /// イベントID
    /// </summary>
    /// <remarks>InstanceIdの下位16ビット</remarks>
    [SupportedOSPlatform("windows")]
    public int EventID => (int)(_eventLogEntry.InstanceId & 0x0000FFFF);

    /// <summary>
    /// イベントログ内でのこのエントリへのインデックス
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int Index => _eventLogEntry.Index;

    /// <summary>
    /// リソース識別子
    /// </summary>
    [SupportedOSPlatform("windows")]
    public long InstanceID => _eventLogEntry.InstanceId;

    /// <summary>
    /// エントリを生成したコンピューター名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string MachineName => _eventLogEntry.MachineName;

    /// <summary>
    /// ローカライズ済みのメッセージ
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Message => _eventLogEntry.Message;

    /// <summary>
    /// 置き換え文字列
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string[] ReplacementStrings => _eventLogEntry.ReplacementStrings;

    /// <summary>
    /// イベントを発生させたアプリケーション名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Source => _eventLogEntry.Source;

    /// <summary>
    /// イベントを発生させた現地時間
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime TimeGenerated => _eventLogEntry.TimeGenerated;

    /// <summary>
    /// イベントログが記録された現地時間
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime TimeWritten => _eventLogEntry.TimeWritten;

    /// <summary>
    /// イベントを発生させたユーザー名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string UserName => _eventLogEntry.UserName;


    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="eventLogEntry">イベントログ エントリ</param>
    internal KEventLogEntry(EventLogEntry eventLogEntry)
    {
        _eventLogEntry = eventLogEntry;
    }
}

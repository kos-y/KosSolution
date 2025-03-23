using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログレコード
/// </summary>
public class KEventLogRecord(EventRecord eventRecord)
{
    /// <summary>
    /// イベントログレコード
    /// </summary>
    private readonly EventLogRecord _eventRecord = (EventLogRecord)eventRecord;

    /// <summary>
    /// イベントID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int EventID => _eventRecord.Id;

    /// <summary>
    /// イベントの重大度
    /// </summary>
    [SupportedOSPlatform("windows")]
    public byte? Level => _eventRecord.Level;

    /// <summary>
    /// ログ名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string LogName => _eventRecord.LogName;

    /// <summary>
    /// このイベントが記録されたコンピューター名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string MachineName => _eventRecord.MachineName;

    /// <summary>
    /// イベントプロバイダーのプロセスID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int? ProcessId => _eventRecord.ProcessId;

    /// <summary>
    /// プロバイダー名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string ProviderName => _eventRecord.ProviderName;

    /// <summary>
    /// イベントレコードID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public long? EventRecordID => _eventRecord.RecordId;

    /// <summary>
    /// イベントログが作成された日時
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime? TimeCreated => _eventRecord.TimeCreated;

    /// <summary>
    /// イベントメッセージ
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string FormatDescription => _eventRecord.FormatDescription();

    /// <summary>
    /// XML
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Xml => _eventRecord.ToXml();
}

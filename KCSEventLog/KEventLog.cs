using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログ
/// </summary>
public class KEventLog
{
    /// <summary>
    /// イベントログ
    /// </summary>
    private EventLog _eventLog;

    /// <summary>
    /// イベントログエントリー
    /// </summary>
    private List<KEventLogEntry>? _entries;

    /// <summary>
    /// イベントログ名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string LogName => _eventLog.Log;

    /// <summary>
    /// イベントログのエントリ群
    /// </summary>
    [SupportedOSPlatform("windows")]
    public List<KEventLogEntry> Entries => _entries ?? LoadEventLogEntries();


    /// <summary>
    /// ローカルコンピューターに登録されている全イベントログを取得
    /// </summary>
    /// <returns>イベントログ</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<KEventLog> GetEventLogsLocalComputer()
    {
        EventLog[] eventLogs = EventLog.GetEventLogs();

        return eventLogs.Select(static e => new KEventLog(e));
    }

    /// <summary>
    /// リモートコンピューターに登録されている全イベントログを取得
    /// </summary>
    /// <param name="machineName">リモートコンピューター名</param>
    /// <returns>イベントログ</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<KEventLog> GetEventLogsRemoteComputer(string machineName)
    {
        EventLog[] eventLogs = EventLog.GetEventLogs(machineName);

        return eventLogs.Select(static e => new KEventLog(e));
    }

    /// <summary>
    /// イベントログファイル（*.evtx）からイベントログの取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFile(string eventLogFilePath)
    {
        using EventLogReader eventLogReader = new(eventLogFilePath, PathType.FilePath);

        ConcurrentBag<KEventLogRecord> records = [];
        EventRecord record;
        while ((record = eventLogReader.ReadEvent()) is not null) {
            records.Add(new KEventLogRecord((EventLogRecord)record));
        }

        return records;
    }

    /// <summary>
    /// イベントログファイル（*.evtx）から指定されたイベントIDのイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="eventID">イベントID</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileFilterEventID(string eventLogFilePath, int eventID)
    {
        KEventLogQuery q = new KEventLogQuery();
        q.AddEventID(eventID);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }

    /// <summary>
    /// イベントログファイル（*.evtx）から指定された期間内のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="begin">開始日時</param>
    /// <param name="end">終了日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileFilterTimeCreated(string eventLogFilePath, DateTime begin, DateTime end)
    {
        KEventLogQuery q = new KEventLogQuery();
        q.AddTimeCreatedGreaterThanOrEqual(begin);
        q.AddTimeCreatedLessThanOrEqual(end);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }

    /// <summary>
    /// イベントログファイル（*.evtx）から指定された期間内のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="begin">開始日時</param>
    /// <param name="end">終了日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileFilterTimeCreatedBegin(string eventLogFilePath, DateTime begin)
    {
        KEventLogQuery q = new KEventLogQuery();
        q.AddTimeCreatedGreaterThanOrEqual(begin);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }

    /// <summary>
    /// イベントログファイル（*.evtx）から指定された期間内のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="begin">開始日時</param>
    /// <param name="end">終了日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileFilterTimeCreatedEnd(string eventLogFilePath, DateTime end)
    {
        KEventLogQuery q = new KEventLogQuery();
        q.AddTimeCreatedLessThanOrEqual(end);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }

    /// <summary>
    /// イベントログファイル（*.evtx）から指定されたコンピュータ名のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="computer">コンピュータ名</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileFilterComputer(string eventLogFilePath, string computer)
    {
        KEventLogQuery q = new KEventLogQuery();
        q.AddComputer(computer);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }

    /// <summary>
    /// クエリを指定してイベントログファイルからイベントログの取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="query">イベントログのクエリ</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static ConcurrentBag<KEventLogRecord> GetEventLogRecordsFromEventLogFileQuery(string eventLogFilePath, KEventLogQuery query)
    {
        EventLogQuery eventLogQuery = new(eventLogFilePath, PathType.FilePath, query.GetQuery());
        EventLogReader eventLogReader = new(eventLogQuery);

        ConcurrentBag<KEventLogRecord> records = [];
        EventRecord record;
        while ((record = eventLogReader.ReadEvent()) is not null) {
            records.Add(new KEventLogRecord((EventLogRecord)record));
        }

        return records;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="eventLog">イベントログ</param>
    private KEventLog(EventLog eventLog)
    {
        _eventLog = eventLog;
        _entries = null;
    }

    /// <summary>
    /// イベントログエントリの読み込み
    /// </summary>
    [SupportedOSPlatform("windows")]
    private List<KEventLogEntry> LoadEventLogEntries()
    {
        _entries = [];

        try {
            foreach (EventLogEntry entry in _eventLog.Entries) {
                _entries.Add(new KEventLogEntry(entry));
            }
        }
        catch (Exception) {
        }

        return _entries;
    }
}

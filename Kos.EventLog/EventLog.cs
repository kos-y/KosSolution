using System.Diagnostics.Eventing.Reader;
using System.Runtime.Versioning;

namespace Kos.EventLog;

/// <summary>
/// イベントログ
/// </summary>
public class EventLog
{
    // フィールド

    #region 内部保持用 イベントログ
    /// <summary>
    /// 内部保持用 イベントログ
    /// </summary>
    private readonly System.Diagnostics.EventLog _eventLog;
    #endregion

    #region 内部保持用 イベントログエントリーリスト
    /// <summary>
    /// 内部保持用 イベントログエントリーリスト
    /// </summary>
    private List<EventLogEntry>? _entries;
    #endregion

    #region イベントログの名前
    /// <summary>
    /// イベントログの名前
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string LogName => _eventLog.Log;
    #endregion

    #region イベントログのエントリー
    /// <summary>
    /// イベントログのエントリー
    /// </summary>
    [SupportedOSPlatform("windows")]
    public List<EventLogEntry> Entries => _entries ?? LoadEventLogEntries();
    #endregion


    // 静的メソッド

    #region 全イベントログの取得 ローカルコンピューター
    /// <summary>
    /// ローカルコンピューターに登録されている全イベントログを取得
    /// </summary>
    /// <returns>イベントログ</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLog> GetEventLogsLocalComputer()
    {
        System.Diagnostics.EventLog[] eventLogs = System.Diagnostics.EventLog.GetEventLogs();

        return eventLogs.Select(static e => new EventLog(e));
    }
    #endregion

    #region 全イベントログの取得 リモートコンピューター
    /// <summary>
    /// リモートコンピューターに登録されている全イベントログを取得
    /// </summary>
    /// <param name="machineName">リモートコンピューター名</param>
    /// <returns>イベントログ</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLog> GetEventLogsRemoteComputer(string machineName)
    {
        System.Diagnostics.EventLog[] eventLogs
            = System.Diagnostics.EventLog.GetEventLogs(machineName);

        return eventLogs.Select(static e => new EventLog(e));
    }
    #endregion

    #region 全イベントログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）からイベントログの取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFile(string eventLogFilePath)
    {
        using EventLogReader eventLogReader = new(eventLogFilePath, PathType.FilePath);

        EventRecord record;
        while ((record = eventLogReader.ReadEvent()) is not null) {
            yield return new EventLogRecord(record);
        }
    }
    #endregion

    #region 指定EventIDに該当するログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）から指定されたイベントIDのイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="eventId">イベントID</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileFilterEventID(string eventLogFilePath, int eventId)
    {
        EventLogQuery q = new();
        q.AddEventID(eventId);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }
    #endregion

    #region 指定期間内に該当するログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）から指定された期間内のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="begin">開始日時</param>
    /// <param name="end">終了日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileFilterTimeCreated(
            string eventLogFilePath, DateTime begin, DateTime end)
    {
        EventLogQuery q = new();
        q.AddTimeCreatedGreaterThanOrEqual(begin);
        q.AddTimeCreatedLessThanOrEqual(end);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }
    #endregion

    #region 指定日時以降に該当するログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）から指定日時以降のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="begin">開始日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileFilterTimeCreatedBegin(
            string eventLogFilePath, DateTime begin)
    {
        EventLogQuery q = new();
        q.AddTimeCreatedGreaterThanOrEqual(begin);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }
    #endregion

    #region 指定日時以前に該当するログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）から指定された日時以前のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="end">終了日時</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileFilterTimeCreatedEnd(
            string eventLogFilePath, DateTime end)
    {
        EventLogQuery q = new();
        q.AddTimeCreatedLessThanOrEqual(end);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }
    #endregion

    #region 指定コンピューターに該当するログの取得 イベントログファイル
    /// <summary>
    /// イベントログファイル（*.evtx）から指定されたコンピュータ名のイベントログを取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="computer">コンピュータ名</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileFilterComputer(string eventLogFilePath, string computer)
    {
        EventLogQuery q = new();
        q.AddComputer(computer);

        return GetEventLogRecordsFromEventLogFileQuery(eventLogFilePath, q);
    }
    #endregion

    #region 指定クエリに該当するログの取得 イベントログファイル
    /// <summary>
    /// クエリを指定してイベントログファイルからイベントログの取得
    /// </summary>
    /// <param name="eventLogFilePath">イベントログファイルへのパス</param>
    /// <param name="query">イベントログのクエリ</param>
    /// <returns>イベントログレコード</returns>
    [SupportedOSPlatform("windows")]
    public static IEnumerable<EventLogRecord>
        GetEventLogRecordsFromEventLogFileQuery(string eventLogFilePath, EventLogQuery query)
    {
        System.Diagnostics.Eventing.Reader.EventLogQuery eventLogQuery
            = new(eventLogFilePath, PathType.FilePath, query.GetQuery());
        EventLogReader eventLogReader = new(eventLogQuery);

        EventRecord record;
        while ((record = eventLogReader.ReadEvent()) is not null) {
            yield return new EventLogRecord(record);
        }
    }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="eventLog">イベントログ</param>
    private EventLog(System.Diagnostics.EventLog eventLog)
    {
        _eventLog = eventLog;
    }
    #endregion

    #region イベントログエントリの読み込み
    /// <summary>
    /// イベントログエントリの読み込み
    /// </summary>
    [SupportedOSPlatform("windows")]
    private List<EventLogEntry> LoadEventLogEntries()
    {
        _entries = [];

        try {
            foreach (System.Diagnostics.EventLogEntry entry in _eventLog.Entries) {
                _entries.Add(new EventLogEntry(entry));
            }
        } catch (Exception) {
        }

        return _entries;
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Kos.EventLog;

/// <summary>
/// イベントログレコード
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="record">イベントレコード</param>
public class EventLogRecord(EventRecord record)
{
    // フィールド

    #region 内部保持用 イベントレコード
    /// <summary>
    /// イベントレコード
    /// </summary>
    private readonly EventRecord _record = record;
    #endregion

    #region イベントID
    /// <summary>
    /// イベントID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int EventId
    {
        get {
            if (_eventIdCache.HasValue) {
                return _eventIdCache.Value;
            }

            _eventIdCache = _record.Id;
            return _eventIdCache.Value;
        }
    }

    /// <summary>
    /// イベントID（キャッシュ）
    /// </summary>
    private int? _eventIdCache = null;
    #endregion

    #region イベントの重大度
    /// <summary>
    /// イベントの重大度
    /// </summary>
    [SupportedOSPlatform("windows")]
    public byte? Level
    {
        get {
            if (_levelCache.HasValue) {
                return _levelCache.Value;
            }

            _levelCache = _record.Level;
            return _levelCache;
        }
    }

    /// <summary>
    /// イベントの重大度 キャッシュ
    /// </summary>
    private byte? _levelCache = null;
    #endregion

    #region イベントログの名前
    /// <summary>
    /// イベントログの名前
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string LogName
    {
        get {
            if (!string.IsNullOrWhiteSpace(_logNameCache)) {
                return _logNameCache;
            }

            _logNameCache = _record.LogName;
            return _logNameCache;
        }
    }

    /// <summary>
    /// イベントログの名前 キャッシュ
    /// </summary>
    private string _logNameCache = string.Empty;
    #endregion

    #region コンピューター名
    /// <summary>
    /// コンピューター名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string MachineName
    {
        get {
            if (!string.IsNullOrWhiteSpace(_machineNameCache)) {
                return _machineNameCache;
            }

            _machineNameCache = _record.MachineName;
            return _machineNameCache;
        }
    }

    /// <summary>
    /// コンピューター名 キャッシュ
    /// </summary>
    private string _machineNameCache = string.Empty;
    #endregion

    #region プロセスID
    /// <summary>
    /// プロセスID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int? ProcessId
    {
        get {
            if (_processIdCache.HasValue) {
                return _processIdCache.Value;
            }

            _processIdCache = _record.ProcessId;
            return _processIdCache;
        }
    }

    /// <summary>
    /// プロセスID キャッシュ
    /// </summary>
    private int? _processIdCache = null;
    #endregion

    #region プロバイダーの名前
    /// <summary>
    /// プロバイダー名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string ProviderName
    {
        get {
            if (!string.IsNullOrWhiteSpace(_providerNameCache)) {
                return _providerNameCache;
            }

            _providerNameCache = _record.ProviderName;
            return _providerNameCache;
        }
    }

    /// <summary>
    /// プロバイダー名 キャッシュ
    /// </summary>
    private string _providerNameCache = string.Empty;
    #endregion

    #region レコードID
    /// <summary>
    /// レコードID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public long? RecordId
    {
        get {
            if (_recordIdCache.HasValue) {
                return _recordIdCache.Value;
            }

            _recordIdCache = _record.RecordId;
            return _recordIdCache;
        }
    }

    /// <summary>
    /// レコードID キャッシュ
    /// </summary>
    private long? _recordIdCache = null;
    #endregion

    #region イベント発生日時
    /// <summary>
    /// イベント発生日時
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime? TimeCreated
    {
        get {
            if (_timeCreatedCache.HasValue) {
                return _timeCreatedCache.Value;
            }

            _timeCreatedCache = _record.TimeCreated;
            return _timeCreatedCache;
        }
    }

    /// <summary>
    /// イベント発生日時 キャッシュ
    /// </summary>
    private DateTime? _timeCreatedCache = null;
    #endregion

    #region メッセージ
    /// <summary>
    /// メッセージ
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Message
    {
        get {
            if (!string.IsNullOrWhiteSpace(_messageCache)) {
                return _messageCache;
            }

            _messageCache = _record.FormatDescription();
            return _messageCache;
        }
    }

    /// <summary>
    /// メッセージ キャッシュ
    /// </summary>
    private string _messageCache = string.Empty;
    #endregion

    #region XML文字列
    /// <summary>
    /// XML文字列
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Xml
    {
        get {
            if (!string.IsNullOrWhiteSpace(_xmlCache)) {
                return _xmlCache;
            }

            _xmlCache = _record.ToXml();
            return _xmlCache;
        }
    }

    /// <summary>
    /// XML文字列 キャッシュ
    /// </summary>
    private string _xmlCache = string.Empty;

    #endregion
}

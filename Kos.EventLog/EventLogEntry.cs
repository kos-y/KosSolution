using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Kos.EventLog;

/// <summary>
/// イベントログエントリー
/// </summary>
public class EventLogEntry
{
    // フィールド

    #region イベントログエントリー
    /// <summary>
    /// イベントログエントリー
    /// </summary>
    private readonly System.Diagnostics.EventLogEntry _entry;
    #endregion

    #region 種別
    /// <summary>
    /// イベントログエントリーの種別
    /// </summary>
    [SupportedOSPlatform("windows")]
    public EventLogEntryType EntryType => _entry.EntryType;
    #endregion

    #region リソース識別子
    /// <summary>
    /// リソース識別子
    /// </summary>
    [SupportedOSPlatform("windows")]
    public long InstanceId => _entry.InstanceId;
    #endregion

    #region イベントID
    /// <summary>
    /// イベントID
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int EventId => (int)(_entry.InstanceId & 0x0000FFFF);
    #endregion

    #region エントリーへのIndex
    /// <summary>
    /// エントリーへのIndex
    /// </summary>
    [SupportedOSPlatform("windows")]
    public int Index => _entry.Index;
    #endregion

    #region メッセージ
    /// <summary>
    /// メッセージ
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Message => _entry.Message;
    #endregion

    #region 置き換え文字列
    /// <summary>
    /// 置き換え文字列
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string[] ReplacementStrings => _entry.ReplacementStrings;
    #endregion

    #region イベントを発生させたアプリケーション名
    /// <summary>
    /// イベントを発生させたアプリケーション名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string Source => _entry.Source;
    #endregion

    #region イベントが発生した日時
    /// <summary>
    /// イベントが発生した日時
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime TimeGenerated => _entry.TimeGenerated;
    #endregion

    #region イベントログを記録した日時
    /// <summary>
    /// イベントログを記録した日時
    /// </summary>
    [SupportedOSPlatform("windows")]
    public DateTime TimeWritten => _entry.TimeWritten;
    #endregion

    #region イベントを発生させたユーザー名
    /// <summary>
    /// イベントを発生させたユーザー名
    /// </summary>
    [SupportedOSPlatform("windows")]
    public string UserName => _entry.UserName;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="eventLogEntry">イベントログ エントリ</param>
    internal EventLogEntry(System.Diagnostics.EventLogEntry eventLogEntry)
    {
        _entry = eventLogEntry;
    }
    #endregion

    #region GetHashCode override
    /// <summary>
    /// ハッシュコードの取得
    /// </summary>
    /// <returns>ハッシュコード</returns>
    [SupportedOSPlatform("windows")]
    public override int GetHashCode()
    {
        return InstanceId.GetHashCode();
    }
    #endregion

    #region Equals override
    /// <summary>
    /// 一致判定
    /// </summary>
    /// <param name="obj">判定対象</param>
    /// <returns>一致したかどうか</returns>
    [SupportedOSPlatform("windows")]
    public override bool Equals(object? obj)
    {
        if (obj is null) {
            return false;
        }

        if (obj is not EventLogEntry entry) {
            return false;
        }

        return InstanceId == entry.InstanceId;
    }
    #endregion
}

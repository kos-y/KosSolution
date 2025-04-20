using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.EventLog;

/// <summary>
/// イベントログ クエリー
/// </summary>
public class EventLogQuery
{
    // フィールド

    #region 絞り込み条件 System配下
    /// <summary>
    /// System配下の絞り込み条件
    /// </summary>
    private readonly List<string> _systemConditions = [];
    #endregion

    #region 絞り込み条件 TimeCreated配下
    /// <summary>
    /// TimeCreatedの絞り込み条件
    /// </summary>
    private readonly List<string> _timeCreatedConditions = [];
    #endregion

    #region 絞り込み条件 EventData配下
    /// <summary>
    /// EventData配下の絞り込み条件
    /// </summary>
    private readonly List<string> _eventDataConditions = [];
    #endregion


    // メソッド

    #region 条件追加 プロバイダーの名前
    /// <summary>
    /// 条件追加 プロバイダーの名前
    /// </summary>
    /// <param name="providerName">Provider Name</param>
    public void AddProvider(string providerName)
    {
        _systemConditions.Add($"(Provider = \'{providerName}\')");
    }
    #endregion

    #region 条件追加 イベントID
    /// <summary>
    /// 条件追加 イベントID
    /// </summary>
    /// <param name="eventId">イベントID</param>
    public void AddEventID(int eventId)
    {
        _systemConditions.Add($"(EventID = {eventId})");
    }
    #endregion

    #region 条件追加 重大度
    /// <summary>
    /// 条件追加 重大度
    /// </summary>
    /// <param name="level">重大度</param>
    public void AddLevel(byte level)
    {
        _systemConditions.Add($"(Level = {level})");
    }
    #endregion

    #region 条件追加 イベント生成日時（以上）
    /// <summary>
    /// 条件追加 イベント生成日時（以上）
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    /// <param name="timeZone">タイムゾーン</param>
    public void AddTimeCreatedGreaterThanOrEqual(DateTime timeCreated, TimeZoneInfo timeZone)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, timeZone);

        _timeCreatedConditions.Add($"(@SystemTime >= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }

    /// <summary>
    /// 条件追加 イベント生成日時（以上）
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    public void AddTimeCreatedGreaterThanOrEqual(DateTime timeCreated)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, TimeZoneInfo.Local);

        _timeCreatedConditions.Add($"(@SystemTime >= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }
    #endregion

    #region 条件追加 イベント生成日時（以下）
    /// <summary>
    /// 条件追加 イベント生成日時（以下）
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    /// <param name="timeZone">タイムゾーン</param>
    public void AddTimeCreatedLessThanOrEqual(DateTime timeCreated, TimeZoneInfo timeZone)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, timeZone);

        _timeCreatedConditions.Add($"(@SystemTime <= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }

    /// <summary>
    /// 条件追加 イベント生成日時（以下）
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    public void AddTimeCreatedLessThanOrEqual(DateTime timeCreated)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, TimeZoneInfo.Local);

        _timeCreatedConditions.Add($"(@SystemTime <= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }
    #endregion

    #region 条件追加 イベントレコードID
    /// <summary>
    /// 条件追加 イベントレコードID
    /// </summary>
    /// <param name="eventRecordId">イベントレコードID</param>
    public void AddEventRecordID(long eventRecordId)
    {
        _systemConditions.Add($"(EventRecordID = {eventRecordId})");
    }
    #endregion

    #region 条件追加 コンピューター名
    /// <summary>
    /// 条件追加 コンピューター名
    /// </summary>
    /// <param name="computerName">コンピューター名</param>
    public void AddComputer(string computerName)
    {
        _systemConditions.Add($"(Computer = \'{computerName}\')");
    }
    #endregion

    #region 条件追加 データ
    /// <summary>
    /// 条件追加 データ
    /// </summary>
    /// <param name="index">インデックス（１開始）</param>
    /// <param name="data">データ</param>
    public void AddData(int index, string data)
    {
        _eventDataConditions.Add($"(Data[{index}] = \'{data}\')");
    }
    #endregion

    #region クエリ文の作成
    /// <summary>
    /// クエリ文の作成
    /// </summary>
    /// <returns>クエリ文</returns>
    internal string GetQuery()
    {
        string query = "*[";

        // TimeGeneratedの条件をSystemに追加
        if (_timeCreatedConditions.Count > 0) {
            _systemConditions.Add($"TimeCreated[{string.Join(" and ", _timeCreatedConditions)}]");
        }

        // System配下のクエリ文を作成
        if (_systemConditions.Count > 0) {
            string system = string.Join(" and ", _systemConditions);
            query += $"System[{system}]";
        }

        // EventData配下のクエリ文を作成
        if (_eventDataConditions.Count > 0) {
            string eventData = string.Join(" and ", _eventDataConditions);
            if (query != "*[") {
                query += " and ";
            }
            query += $"EventData[{eventData}]";
        }

        query += "]";

        return query;
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSEventLog;

/// <summary>
/// イベントログ 絞り込み条件
/// </summary>
public class KEventLogQuery
{
    /// <summary>
    /// System配下の絞り込み条件
    /// </summary>
    private readonly List<string> _systemConditions = [];

    /// <summary>
    /// TimeCreatedの絞り込み条件
    /// </summary>
    private readonly List<string> _timeCreatedConditions = [];

    /// <summary>
    /// EventData配下の絞り込み条件
    /// </summary>
    private readonly List<string> _eventDataConditions = [];


    /// <summary>
    /// Provider Nameの条件追加
    /// </summary>
    /// <param name="providerName">Provider Name</param>
    public void AddProvider(string providerName)
    {
        _systemConditions.Add($"(Provider = \'{providerName}\')");
    }

    /// <summary>
    /// イベントIDの追加
    /// </summary>
    /// <param name="eventID">イベントID</param>
    public void AddEventID(int eventID)
    {
        _systemConditions.Add($"(EventID = {eventID})");
    }

    /// <summary>
    /// 重大度の追加
    /// </summary>
    /// <param name="level">重大度</param>
    public void AddLevel(byte level)
    {
        _systemConditions.Add($"(Level = {level})");
    }

    /// <summary>
    /// イベント生成日時（以上）の追加
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
    /// イベント生成日時（以上）の追加
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    public void AddTimeCreatedGreaterThanOrEqual(DateTime timeCreated)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, TimeZoneInfo.Local);

        _timeCreatedConditions.Add($"(@SystemTime >= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }

    /// <summary>
    /// イベント生成日時（以下）の追加
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
    /// イベント生成日時（以下）の追加
    /// </summary>
    /// <param name="timeCreated">イベント発生日時</param>
    public void AddTimeCreatedLessThanOrEqual(DateTime timeCreated)
    {
        // タイムゾーンにあわせて、世界標準時刻に変換
        DateTime utc = TimeZoneInfo.ConvertTimeToUtc(timeCreated, TimeZoneInfo.Local);

        _timeCreatedConditions.Add($"(@SystemTime <= \'{utc:yyyy-MM-ddTHH:mm:ss.000Z}\')");
    }

    /// <summary>
    /// イベントレコードIDの追加
    /// </summary>
    /// <param name="eventRecordID">イベントレコードID</param>
    public void AddEventRecordID(long eventRecordID)
    {
        _systemConditions.Add($"(EventRecordID = {eventRecordID})");
    }

    /// <summary>
    /// コンピュータ名の追加
    /// </summary>
    /// <param name="computerName">コンピューター名</param>
    public void AddComputer(string computerName)
    {
        _systemConditions.Add($"(Computer = \'{computerName}\')");
    }

    /// <summary>
    /// データの追加
    /// </summary>
    /// <param name="index">インデックス（１開始）</param>
    /// <param name="data">データ</param>
    public void AddData(int index, string data)
    {
        _eventDataConditions.Add($"(Data[{index}] = \'{data}\')");
    }

    /// <summary>
    /// EventLogQueryに渡すクエリ文の作成
    /// </summary>
    /// <returns></returns>
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
}

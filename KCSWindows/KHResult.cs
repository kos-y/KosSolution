namespace KCSWindows;

/// <summary>
/// HRESULT
/// </summary>
/// <param name="hResult">HRESULT値</param>
public class KHResult(int hResult)
{
    /// <summary>
    /// HRESULT値
    /// </summary>
    public int HResult = hResult;

    /// <summary>
    /// エラー（FAILED）
    /// </summary>
    public bool IsFailed => HResult < 0;

    /// <summary>
    /// コード部の取得（HRESULT_CODE）
    /// </summary>
    public int Code => HResult & 0xFFFF;

    /// <summary>
    /// 機能部の取得（HRESULT_FACILITY）
    /// </summary>
    public int Facility => (int)((uint)HResult << 16) & 0x1FFF;

    /// <summary>
    /// 重大度（HRESULT_SEVERITY）
    /// </summary>
    public byte Serverity => (byte)(((uint)HResult >> 31) & 0x0001);

    /// <summary>
    /// 成功（SUCCEEDED）
    /// </summary>
    public bool IsSucceeded => HResult >= 0;
}

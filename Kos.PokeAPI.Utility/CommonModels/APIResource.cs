using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// APIリソース
/// </summary>
public class APIResource
{
    #region URL
    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    #endregion
}

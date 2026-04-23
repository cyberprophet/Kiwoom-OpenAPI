using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.RealType;

/// <summary>선물옵션우선호가</summary>
public class PriorityQuote
{
    /// <summary>0.10.현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10)]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>1.27.(최우선)매도호가</summary>
    [DataMember, JsonProperty("(최우선)매도호가"), StringLength(0x10)]
    public string? TopPriorityAskPrice
    {
        get; set;
    }

    /// <summary>2.28.(최우선)매수호가</summary>
    [DataMember, JsonProperty("(최우선)매수호가"), StringLength(0x10)]
    public string? TopPriorityBidPrice
    {
        get; set;
    }
}
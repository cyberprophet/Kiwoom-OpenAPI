using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물옵션현재가정보</summary>
public class SingleOPT50019
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명"), StringLength(0x40)]
    public string? Name
    {
        get; set;
    }

    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(8)]
    public string? PresentPrice
    {
        get; set;
    }

    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호"), StringLength(8)]
    public string? ContrastSymbol
    {
        get; set;
    }

    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(8)]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }

    /// <summary>내재가치</summary>
    [DataMember, JsonProperty("내재가치"), StringLength(8)]
    public string? IntrinsicValue
    {
        get; set;
    }

    /// <summary>시간가치</summary>
    [DataMember, JsonProperty("시간가치"), StringLength(8)]
    public string? TimeValue
    {
        get; set;
    }

    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가"), StringLength(8)]
    public string? Theorist
    {
        get; set;
    }

    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(8)]
    public string? StartPrice
    {
        get; set;
    }

    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(8)]
    public string? HighPrice
    {
        get; set;
    }

    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(8)]
    public string? LowPrice
    {
        get; set;
    }

    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량"), StringLength(8)]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }

    /// <summary>거래량전일대비</summary>
    [DataMember, JsonProperty("거래량전일대비"), StringLength(8)]
    public string? TradingVolumeDayOnDay
    {
        get; set;
    }

    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금"), StringLength(8)]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }

    /// <summary>거래대금증감</summary>
    [DataMember, JsonProperty("거래대금증감"), StringLength(8)]
    public string? IncreaseOrDecreaseInTransactionPrice
    {
        get; set;
    }

    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정"), StringLength(8)]
    public string? OpenInterest
    {
        get; set;
    }

    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비"), StringLength(8)]
    public string? ComparedToThePreviousDayOfTheOutstandingPayment
    {
        get; set;
    }

    /// <summary>역사적변동성</summary>
    [DataMember, JsonProperty("역사적변동성"), StringLength(8)]
    public string? HistoricalVolatility
    {
        get; set;
    }

    /// <summary>표면이자</summary>
    [DataMember, JsonProperty("표면이자"), StringLength(8)]
    public string? SurfaceInterest
    {
        get; set;
    }

    /// <summary>배당액지수</summary>
    [DataMember, JsonProperty("배당액지수"), StringLength(8)]
    public string? DividendIndex
    {
        get; set;
    }

    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가"), StringLength(8)]
    public string? SellingPrice
    {
        get; set;
    }

    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량"), StringLength(8)]
    public string? SalesVolume
    {
        get; set;
    }

    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가"), StringLength(8)]
    public string? BuyInPrice
    {
        get; set;
    }

    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량"), StringLength(8)]
    public string? PurchaseQuantity
    {
        get; set;
    }
}
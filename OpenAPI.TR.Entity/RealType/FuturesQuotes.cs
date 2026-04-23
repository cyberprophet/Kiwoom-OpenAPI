using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.RealType;

/// <summary>선물시세</summary>
public class FuturesQuotes
{
    /// <summary>0.20.체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>1.10.현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? CurrentPrice
    {
        get; set;
    }
    /// <summary>2.11.전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? CompareToPreviousDay
    {
        get; set;
    }
    /// <summary>3.12.등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? Rate
    {
        get; set;
    }
    /// <summary>4.27.(최우선)매도호가</summary>
    [DataMember, JsonProperty("(최우선)매도호가")]
    public string? FirstAskPrice
    {
        get; set;
    }
    /// <summary>5.28.(최우선)매수호가</summary>
    [DataMember, JsonProperty("(최우선)매수호가")]
    public string? FirstBidPrice
    {
        get; set;
    }
    /// <summary>6.15.거래량(+는 매수체결, -는 매도체결)</summary>
    [DataMember, JsonProperty("거래량")]
    public string? Volume
    {
        get; set;
    }
    /// <summary>7.13.누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? TotalVolume
    {
        get; set;
    }
    /// <summary>8.14.누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? TotalTransactionAmount
    {
        get; set;
    }
    /// <summary>9.16.시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? OpenPrice
    {
        get; set;
    }
    /// <summary>10.17.고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>11.18.저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>12.195.미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>13.182.이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? TheoreticalPrice
    {
        get; set;
    }
    /// <summary>14.184.이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스")]
    public string? TheoreticalBasis
    {
        get; set;
    }
    /// <summary>15.183.시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>16.186.괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparityRatio
    {
        get; set;
    }
    /// <summary>17.181.미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? OpenInterestComparedToPreviousDay
    {
        get; set;
    }
    /// <summary>18.185.괴리도</summary>
    [DataMember, JsonProperty("괴리도")]
    public string? Disparity
    {
        get; set;
    }
    /// <summary>19.25.전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? CompareToPreviousSign
    {
        get; set;
    }
    /// <summary>20.197.KOSPI200</summary>
    [DataMember, JsonProperty(nameof(KOSPI200))]
    public string? KOSPI200
    {
        get; set;
    }
    /// <summary>21.26.전일거래량대비(계약, 주)</summary>
    [DataMember, JsonProperty("전일거래량대비")]
    public string? CompareToPreviousVolume
    {
        get; set;
    }
    /// <summary>22.246.시초미결제약정수량</summary>
    [DataMember, JsonProperty("시초미결제약정수량")]
    public string? OpenMarketOpenInterest
    {
        get; set;
    }
    /// <summary>23.247.최고미결제약정수량</summary>
    [DataMember, JsonProperty("최고미결제약정수량")]
    public string? HighestOpenInterest
    {
        get; set;
    }
    /// <summary>24.248.최저미결제약정수량</summary>
    [DataMember, JsonProperty("최저미결제약정수량")]
    public string? LowestOpenInterest
    {
        get; set;
    }
    /// <summary>25.30.전일거래량대비(비율)</summary>
    [DataMember, JsonProperty("전일거래량대비(비율)")]
    public string? CompareToPreviousRatio
    {
        get; set;
    }
    /// <summary>26.196.미결제증감</summary>
    [DataMember, JsonProperty("미결제증감")]
    public string? IncreaseOpenInterest
    {
        get; set;
    }
    /// <summary>34.1365.실시간상한가</summary>
    [DataMember, JsonProperty("실시간상한가")]
    public string? RealTimeUpperPrice
    {
        get; set;
    }
    /// <summary>35.1366.실시간하한가</summary>
    [DataMember, JsonProperty("실시간하한가")]
    public string? RealTimeLowestPrice
    {
        get; set;
    }
    /// <summary>36.1367.협의대량누적체결수량</summary>
    [DataMember, JsonProperty("협의대량누적체결수량")]
    public string? BulkCumulativeContractQuantity
    {
        get; set;
    }
    /// <summary>37.305.상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? UpperPrice
    {
        get; set;
    }
    /// <summary>38.306.하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? LowestPrice
    {
        get; set;
    }
}
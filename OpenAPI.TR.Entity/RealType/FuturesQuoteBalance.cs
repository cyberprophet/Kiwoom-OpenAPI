using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.RealType;

/// <summary>선물호가잔량</summary>
public class FuturesQuoteBalance
{
    /// <summary>0.21.호가시간</summary>
    [DataMember, JsonProperty("호가시간"), StringLength(8)]
    public string? Time
    {
        get; set;
    }
    /// <summary>1.27.(최우선)매도호가</summary>
    [DataMember, JsonProperty("(최우선)매도호가")]
    public string? TopPriorityAskPrice
    {
        get; set;
    }
    /// <summary>2.28.(최우선)매수호가</summary>
    [DataMember, JsonProperty("(최우선)매수호가")]
    public string? TopPriorityBidPrice
    {
        get; set;
    }
    /// <summary>3.41.매도호가1</summary>
    [DataMember, JsonProperty("매도호가1")]
    public string? FirstAskPrice
    {
        get; set;
    }
    /// <summary>4.61.매도호가수량1</summary>
    [DataMember, JsonProperty("매도호가수량1")]
    public string? FirstAskAmount
    {
        get; set;
    }
    /// <summary>5.81.매도호가직전대비1</summary>
    [DataMember, JsonProperty("매도호가직전대비1")]
    public string? ComparedToFirstAskBalance
    {
        get; set;
    }
    /// <summary>6.101.매도호가건수1</summary>
    [DataMember, JsonProperty("매도호가건수1")]
    public string? FirstAskBalance
    {
        get; set;
    }
    /// <summary>7.51.매수호가1</summary>
    [DataMember, JsonProperty("매수호가1")]
    public string? FirstBidPrice
    {
        get; set;
    }
    /// <summary>8.71.매수호가수량1</summary>
    [DataMember, JsonProperty("매수호가수량1")]
    public string? FirstBidAmount
    {
        get; set;
    }
    /// <summary>9.91.매수호가직전대비1</summary>
    [DataMember, JsonProperty("매수호가직전대비1")]
    public string? ComparedToFirstBidBalance
    {
        get; set;
    }
    /// <summary>10.111.매수호가건수1</summary>
    [DataMember, JsonProperty("매수호가건수1")]
    public string? FirstBidBalance
    {
        get; set;
    }
    /// <summary>11.42.매도호가2</summary>
    [DataMember, JsonProperty("매도호가2")]
    public string? SecondAskPrice
    {
        get; set;
    }
    /// <summary>12.62.매도호가수량2</summary>
    [DataMember, JsonProperty("매도호가수량2")]
    public string? SecondAskAmount
    {
        get; set;
    }
    /// <summary>13.82.매도호가직전대비2</summary>
    [DataMember, JsonProperty("매도호가직전대비2")]
    public string? ComparedToSecondAskBalance
    {
        get; set;
    }
    /// <summary>14.102.매도호가건수2</summary>
    [DataMember, JsonProperty("매도호가건수2")]
    public string? SecondAskBalance
    {
        get; set;
    }
    /// <summary>15.52.매수호가2</summary>
    [DataMember, JsonProperty("매수호가2")]
    public string? SecondBidPrice
    {
        get; set;
    }
    /// <summary>16.72.매수호가수량2</summary>
    [DataMember, JsonProperty("매수호가수량2")]
    public string? SecondBidAmount
    {
        get; set;
    }
    /// <summary>17.92.매수호가직전대비2</summary>
    [DataMember, JsonProperty("매수호가직전대비2")]
    public string? ComparedToSecondBidBalance
    {
        get; set;
    }
    /// <summary>18.112.매수호가건수2</summary>
    [DataMember, JsonProperty("매수호가건수2")]
    public string? SecondBidBalance
    {
        get; set;
    }
    /// <summary>19.43.매도호가3</summary>
    [DataMember, JsonProperty("매도호가3")]
    public string? ThirdAskPrice
    {
        get; set;
    }
    /// <summary>20.63.매도호가수량3</summary>
    [DataMember, JsonProperty("매도호가수량3")]
    public string? ThirdAskAmount
    {
        get; set;
    }
    /// <summary>21.83.매도호가직전대비3</summary>
    [DataMember, JsonProperty("매도호가직전대비3")]
    public string? ComparedToThirdAskBalance
    {
        get; set;
    }
    /// <summary>22.103.매도호가건수3</summary>
    [DataMember, JsonProperty("매도호가건수3")]
    public string? ThirdAskBalance
    {
        get; set;
    }
    /// <summary>23.53.매수호가3</summary>
    [DataMember, JsonProperty("매수호가3")]
    public string? ThirdBidPrice
    {
        get; set;
    }
    /// <summary>24.73.매수호가수량3</summary>
    [DataMember, JsonProperty("매수호가수량3")]
    public string? ThirdBidAmount
    {
        get; set;
    }
    /// <summary>25.93.매수호가직전대비3</summary>
    [DataMember, JsonProperty("매수호가직전대비3")]
    public string? ComparedToThirdBidBalance
    {
        get; set;
    }
    /// <summary>26.113.매수호가건수3</summary>
    [DataMember, JsonProperty("매수호가건수3")]
    public string? ThirdBidBalance
    {
        get; set;
    }
    /// <summary>27.44.매도호가4</summary>
    [DataMember, JsonProperty("매도호가4")]
    public string? FourthAskPrice
    {
        get; set;
    }
    /// <summary>28.64.매도호가수량4</summary>
    [DataMember, JsonProperty("매도호가수량4")]
    public string? FourthAskAmount
    {
        get; set;
    }
    /// <summary>29.84.매도호가직전대비4</summary>
    [DataMember, JsonProperty("매도호가직전대비4")]
    public string? ComparedToFourthAskBalance
    {
        get; set;
    }
    /// <summary>30.104.매도호가건수4</summary>
    [DataMember, JsonProperty("매도호가건수4")]
    public string? FourthAskBalance
    {
        get; set;
    }
    /// <summary>31.54.매수호가4</summary>
    [DataMember, JsonProperty("매수호가4")]
    public string? FourthBidPrice
    {
        get; set;
    }
    /// <summary>32.74.매수호가수량4</summary>
    [DataMember, JsonProperty("매수호가수량4")]
    public string? FourthBidAmount
    {
        get; set;
    }
    /// <summary>33.94.매수호가직전대비4</summary>
    [DataMember, JsonProperty("매수호가직전대비4")]
    public string? ComparedToFourthBidBalance
    {
        get; set;
    }
    /// <summary>34.114.매수호가건수4</summary>
    [DataMember, JsonProperty("매수호가건수4")]
    public string? FourthBidBalance
    {
        get; set;
    }
    /// <summary>35.45.매도호가5</summary>
    [DataMember, JsonProperty("매도호가5")]
    public string? FifthAskPrice
    {
        get; set;
    }
    /// <summary>36.65.매도호가수량5</summary>
    [DataMember, JsonProperty("매도호가수량5")]
    public string? FifthAskAmount
    {
        get; set;
    }
    /// <summary>37.85.매도호가직전대비5</summary>
    [DataMember, JsonProperty("매도호가직전대비5")]
    public string? ComparedToFifthAskBalance
    {
        get; set;
    }
    /// <summary>38.105.매도호가건수5</summary>
    [DataMember, JsonProperty("매도호가건수5")]
    public string? FifthAskBalance
    {
        get; set;
    }
    /// <summary>39.55.매수호가5</summary>
    [DataMember, JsonProperty("매수호가5")]
    public string? FifthBidPrice
    {
        get; set;
    }
    /// <summary>40.75.매수호가수량5</summary>
    [DataMember, JsonProperty("매수호가수량5")]
    public string? FifthBidAmount
    {
        get; set;
    }
    /// <summary>41.95.매수호가직전대비5</summary>
    [DataMember, JsonProperty("매수호가직전대비5")]
    public string? ComparedToFifthBidBalance
    {
        get; set;
    }
    /// <summary>42.115.매수호가건수5</summary>
    [DataMember, JsonProperty("매수호가건수5")]
    public string? FifthBidBalance
    {
        get; set;
    }
    /// <summary>43.121.매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? TotalAskAmount
    {
        get; set;
    }
    /// <summary>44.122.매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매도호가총잔량직전대비")]
    public string? ComparedToTotalAskBalance
    {
        get; set;
    }
    /// <summary>45.123.매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수")]
    public string? TotalAskBalance
    {
        get; set;
    }
    /// <summary>46.125.매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? TotalBidAmount
    {
        get; set;
    }
    /// <summary>47.126.매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매수호가총잔량직전대비")]
    public string? ComparedToTotalBidBalance
    {
        get; set;
    }
    /// <summary>48.127.매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수")]
    public string? TotalBidBalance
    {
        get; set;
    }
    /// <summary>49.137.호가순잔량</summary>
    [DataMember, JsonProperty("호가순잔량")]
    public string? NetBalance
    {
        get; set;
    }
    /// <summary>50.128.순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? NetBidBalance
    {
        get; set;
    }
    /// <summary>51.13.누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? CumulativeTradingVolume
    {
        get; set;
    }
    /// <summary>52.23.예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>53.238.예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비기호")]
    public string? EstimatedClosingSign
    {
        get; set;
    }
    /// <summary>54.200.예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비")]
    public string? EstimatedClosingPriceComparedToPreviousDay
    {
        get; set;
    }
    /// <summary>55.201.예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율")]
    public string? EstimatedClosingRateComparedToPreviousDay
    {
        get; set;
    }
    /// <summary>56.291.예상체결가(예상체결 시간동안에만 유효한 값)</summary>
    [DataMember, JsonProperty("예상체결가(예상체결시간동안유효한값)")]
    public string? EstimatedPrice
    {
        get; set;
    }
    /// <summary>57.293.예상체결가전일대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일대비기호")]
    public string? EstimatedComparedToPreviousSign
    {
        get; set;
    }
    /// <summary>58.294.예상체결가전일대비</summary>
    [DataMember, JsonProperty("예상체결가전일대비")]
    public string? EstimatedComparedToPreviousDay
    {
        get; set;
    }
    /// <summary>59.295.예상체결가전일대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일대비등락율")]
    public string? EstimatedComparedToPreviousRate
    {
        get; set;
    }
}
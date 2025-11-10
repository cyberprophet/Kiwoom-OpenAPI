using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵현재가정보</summary>
public class SingleOpt50001
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(8)]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호"), StringLength(8)]
    public string? CompareToPreviousSign
    {
        get; set;
    }

    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(8)]
    public string? CompareToPreviousDay
    {
        get; set;
    }

    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율"), StringLength(0x10)]
    public string? Rate
    {
        get; set;
    }

    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(8)]
    public string? TradingVolume
    {
        get; set;
    }

    /// <summary>거래량대비</summary>
    [DataMember, JsonProperty("거래량대비"), StringLength(0x10)]
    public string? CompareToPreviousVolume
    {
        get; set;
    }

    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가"), StringLength(8)]
    public string? StandardPrice
    {
        get; set;
    }

    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가"), StringLength(8)]
    public string? TheoryPrice
    {
        get; set;
    }

    /// <summary>이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스"), StringLength(8)]
    public string? TheoryBasis
    {
        get; set;
    }

    /// <summary>괴리도</summary>
    [DataMember, JsonProperty("괴리도"), StringLength(8)]
    public string? Disparity
    {
        get; set;
    }

    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율"), StringLength(0x10)]
    public string? DisparityRatio
    {
        get; set;
    }

    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스"), StringLength(8)]
    public string? MarketBasis
    {
        get; set;
    }

    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금"), StringLength(0x10)]
    public string? TransactionAmount
    {
        get; set;
    }

    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가"), StringLength(8)]
    public string? UpperLimit
    {
        get; set;
    }

    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가"), StringLength(8)]
    public string? LowerLimit
    {
        get; set;
    }

    /// <summary>CB상한가</summary>
    [DataMember, JsonProperty("CB상한가"), StringLength(8)]
    public string? CBUpperLimit
    {
        get; set;
    }

    /// <summary>CB하한가</summary>
    [DataMember, JsonProperty("CB하한가"), StringLength(8)]
    public string? CBLowerLimit
    {
        get; set;
    }

    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가"), StringLength(8)]
    public string? SubstitutePrice
    {
        get; set;
    }

    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일"), StringLength(8)]
    public string? FinalTransactionDate
    {
        get; set;
    }

    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수"), StringLength(8)]
    public string? RemainingDays
    {
        get; set;
    }

    /// <summary>영업일기준잔존일</summary>
    [DataMember, JsonProperty("영업일기준잔존일"), StringLength(8)]
    public string? RemainingDaysBasedOnBusinessDays
    {
        get; set;
    }

    /// <summary>상장중최고가</summary>
    [DataMember, JsonProperty("상장중최고가"), StringLength(8)]
    public string? HighestPrice
    {
        get; set;
    }

    /// <summary>상장중최고가대비율</summary>
    [DataMember, JsonProperty("상장중최고가대비율"), StringLength(0x10)]
    public string? HighestRatio
    {
        get; set;
    }

    /// <summary>상장중최고가일</summary>
    [DataMember, JsonProperty("상장중최고가일"), StringLength(8)]
    public string? HighestPriceDate
    {
        get; set;
    }

    /// <summary>상장중최저가</summary>
    [DataMember, JsonProperty("상장중최저가"), StringLength(8)]
    public string? LowestPrice
    {
        get; set;
    }

    /// <summary>상장중최저가대비율</summary>
    [DataMember, JsonProperty("상장중최저가대비율"), StringLength(0x10)]
    public string? LowestRatio
    {
        get; set;
    }

    /// <summary>상장중최저가일</summary>
    [DataMember, JsonProperty("상장중최저가일"), StringLength(8)]
    public string? LowestPriceDate
    {
        get; set;
    }

    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명"), StringLength(0x20)]
    public string? Name
    {
        get; set;
    }

    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간"), StringLength(8)]
    public string? QuoteTime
    {
        get; set;
    }

    /// <summary>매도수익율5</summary>
    [DataMember, JsonProperty("매도수익율5"), StringLength(8)]
    public string? FifthAskRate
    {
        get; set;
    }

    /// <summary>매도건수5</summary>
    [DataMember, JsonProperty("매도건수5"), StringLength(8)]
    public string? ComparedToFifthAskBalance
    {
        get; set;
    }

    /// <summary>매도수량5</summary>
    [DataMember, JsonProperty("매도수량5"), StringLength(8)]
    public string? FifthAskBalance
    {
        get; set;
    }

    /// <summary>매도수익율4</summary>
    [DataMember, JsonProperty("매도수익율4"), StringLength(8)]
    public string? FourthAskRate
    {
        get; set;
    }

    /// <summary>매도건수4</summary>
    [DataMember, JsonProperty("매도건수4"), StringLength(8)]
    public string? ComparedToFourthAskBalance
    {
        get; set;
    }

    /// <summary>매도수량4</summary>
    [DataMember, JsonProperty("매도수량4"), StringLength(8)]
    public string? FourthAskBalance
    {
        get; set;
    }

    /// <summary>매도호가4</summary>
    [DataMember, JsonProperty("매도호가4"), StringLength(8)]
    public string? FourthAskPrice
    {
        get; set;
    }

    /// <summary>매도호가5</summary>
    [DataMember, JsonProperty("매도호가5"), StringLength(8)]
    public string? FifthAskPrice
    {
        get; set;
    }

    /// <summary>매도수익율3</summary>
    [DataMember, JsonProperty("매도수익율3"), StringLength(8)]
    public string? ThirdAskRate
    {
        get; set;
    }

    /// <summary>매도건수3</summary>
    [DataMember, JsonProperty("매도건수3"), StringLength(8)]
    public string? ComparedToThirdAskBalance
    {
        get; set;
    }

    /// <summary>매도수량3</summary>
    [DataMember, JsonProperty("매도수량3"), StringLength(8)]
    public string? ThirdAskBalance
    {
        get; set;
    }

    /// <summary>매도호가3</summary>
    [DataMember, JsonProperty("매도호가3"), StringLength(8)]
    public string? ThirdAskPrice
    {
        get; set;
    }

    /// <summary>매도수익율2</summary>
    [DataMember, JsonProperty("매도수익율2"), StringLength(8)]
    public string? SecondAskRate
    {
        get; set;
    }

    /// <summary>매도건수2</summary>
    [DataMember, JsonProperty("매도건수2"), StringLength(8)]
    public string? ComparedToSecondAskBalance
    {
        get; set;
    }

    /// <summary>매도수량2</summary>
    [DataMember, JsonProperty("매도수량2"), StringLength(8)]
    public string? SecondAskBalance
    {
        get; set;
    }

    /// <summary>매도호가2</summary>
    [DataMember, JsonProperty("매도호가2"), StringLength(8)]
    public string? SecondAskPrice
    {
        get; set;
    }

    /// <summary>매도수익율1</summary>
    [DataMember, JsonProperty("매도수익율1"), StringLength(8)]
    public string? FirstAskRate
    {
        get; set;
    }

    /// <summary>매도건수1</summary>
    [DataMember, JsonProperty("매도건수1"), StringLength(8)]
    public string? ComparedToFirstAskBalance
    {
        get; set;
    }

    /// <summary>매도수량1</summary>
    [DataMember, JsonProperty("매도수량1"), StringLength(8)]
    public string? FirstAskBalance
    {
        get; set;
    }

    /// <summary>매도호가1</summary>
    [DataMember, JsonProperty("매도호가1"), StringLength(8)]
    public string? FirstAskPrice
    {
        get; set;
    }

    /// <summary>매수호가1</summary>
    [DataMember, JsonProperty("매수호가1"), StringLength(8)]
    public string? FirstBidPrice
    {
        get; set;
    }

    /// <summary>매수수량1</summary>
    [DataMember, JsonProperty("매수수량1"), StringLength(8)]
    public string? FirstBidBalance
    {
        get; set;
    }

    /// <summary>매수건수1</summary>
    [DataMember, JsonProperty("매수건수1"), StringLength(8)]
    public string? ComparedToFirstBidBalance
    {
        get; set;
    }

    /// <summary>매수수익율1</summary>
    [DataMember, JsonProperty("매수수익율1"), StringLength(8)]
    public string? FirstBidRate
    {
        get; set;
    }

    /// <summary>매수호가2</summary>
    [DataMember, JsonProperty("매수호가2"), StringLength(8)]
    public string? SecondBidPrice
    {
        get; set;
    }

    /// <summary>매수수량2</summary>
    [DataMember, JsonProperty("매수수량2"), StringLength(8)]
    public string? SecondBidBalance
    {
        get; set;
    }

    /// <summary>매수건수2</summary>
    [DataMember, JsonProperty("매수건수2"), StringLength(8)]
    public string? ComparedToSecondBidBalance
    {
        get; set;
    }

    /// <summary>매수수익율2</summary>
    [DataMember, JsonProperty("매수수익율2"), StringLength(8)]
    public string? SecondBidRate
    {
        get; set;
    }

    /// <summary>매수호가3</summary>
    [DataMember, JsonProperty("매수호가3"), StringLength(8)]
    public string? ThirdBidPrice
    {
        get; set;
    }

    /// <summary>매수수량3</summary>
    [DataMember, JsonProperty("매수수량3"), StringLength(8)]
    public string? ThirdBidBalance
    {
        get; set;
    }

    /// <summary>매수건수3</summary>
    [DataMember, JsonProperty("매수건수3"), StringLength(8)]
    public string? ComparedToThirdBidBalance
    {
        get; set;
    }

    /// <summary>매수수익율3</summary>
    [DataMember, JsonProperty("매수수익율3"), StringLength(8)]
    public string? ThirdBidRate
    {
        get; set;
    }

    /// <summary>매수호가4</summary>
    [DataMember, JsonProperty("매수호가4"), StringLength(8)]
    public string? FourthBidPrice
    {
        get; set;
    }

    /// <summary>매수수량4</summary>
    [DataMember, JsonProperty("매수수량4"), StringLength(8)]
    public string? FourthBidBalance
    {
        get; set;
    }

    /// <summary>매수건수4</summary>
    [DataMember, JsonProperty("매수건수4"), StringLength(8)]
    public string? ComparedToFourthBidBalance
    {
        get; set;
    }

    /// <summary>매수수익율4</summary>
    [DataMember, JsonProperty("매수수익율4"), StringLength(8)]
    public string? FourthBidRate
    {
        get; set;
    }

    /// <summary>매수호가5</summary>
    [DataMember, JsonProperty("매수호가5"), StringLength(8)]
    public string? FifthBidPrice
    {
        get; set;
    }

    /// <summary>매수수량5</summary>
    [DataMember, JsonProperty("매수수량5"), StringLength(8)]
    public string? FifthBidBalance
    {
        get; set;
    }

    /// <summary>매수건수5</summary>
    [DataMember, JsonProperty("매수건수5"), StringLength(8)]
    public string? ComparedToFifthBidBalance
    {
        get; set;
    }

    /// <summary>매수수익율5</summary>
    [DataMember, JsonProperty("매수수익율5"), StringLength(8)]
    public string? FifthBidRate
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

    /// <summary>2차저항</summary>
    [DataMember, JsonProperty("2차저항"), StringLength(8)]
    public string? SecondaryResistance
    {
        get; set;
    }

    /// <summary>1차저항</summary>
    [DataMember, JsonProperty("1차저항"), StringLength(8)]
    public string? PrimaryResistance
    {
        get; set;
    }

    /// <summary>피봇</summary>
    [DataMember, JsonProperty("피봇"), StringLength(8)]
    public string? Pivot
    {
        get; set;
    }

    /// <summary>1차저지</summary>
    [DataMember, JsonProperty("1차저지"), StringLength(8)]
    public string? FirstBlock
    {
        get; set;
    }

    /// <summary>2차저지</summary>
    [DataMember, JsonProperty("2차저지"), StringLength(8)]
    public string? SecondaryBlock
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
    public string? OpenInterestComparedToPreviousDay
    {
        get; set;
    }

    /// <summary>매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수"), StringLength(8)]
    public string? TotalAsk
    {
        get; set;
    }

    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량"), StringLength(8)]
    public string? TotalAskBalance
    {
        get; set;
    }

    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량"), StringLength(8)]
    public string? NetBidBalance
    {
        get; set;
    }

    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량"), StringLength(8)]
    public string? TotalBidBalance
    {
        get; set;
    }

    /// <summary>매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수"), StringLength(8)]
    public string? TotalBid
    {
        get; set;
    }

    /// <summary>매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매도호가총잔량직전대비"), StringLength(8)]
    public string? ComparedToTotalAskBalance
    {
        get; set;
    }

    /// <summary>매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매수호가총잔량직전대비"), StringLength(8)]
    public string? ComparedToTotalBidBalance
    {
        get; set;
    }

    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가"), StringLength(8)]
    public string? EstimatedClosingPrice
    {
        get; set;
    }

    /// <summary>예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비기호"), StringLength(8)]
    public string? EstimatedClosingSign
    {
        get; set;
    }

    /// <summary>예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비"), StringLength(8)]
    public string? EstimatedClosingPriceComparedToPreviousDay
    {
        get; set;
    }

    /// <summary>예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율"), StringLength(8)]
    public string? EstimatedClosingRateComparedToPreviousDay
    {
        get; set;
    }

    /// <summary>이자율</summary>
    [DataMember, JsonProperty("이자율"), StringLength(8)]
    public string? InterestRate
    {
        get; set;
    }
}
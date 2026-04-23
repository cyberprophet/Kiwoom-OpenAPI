namespace ShareInvest.Interface;

public class Conclusion
{
    /// <summary>원주문번호</summary>
    public string? OrgOrdNo
    {
        get; set;
    }

    /// <summary>매도수구분</summary>
    public OrderStatus OrderStatus
    {
        get; set;
    }
    
    /// <summary>주문수량</summary>
    public int OrderQuantity
    {
        get; set;
    }

    /// <summary>미체결수량</summary>
    public int UntradedQuantity
    {
        get; set;
    }

    /// <summary>주문가격</summary>
    public double OrderPrice
    {
        get; set;
    }

    /// <summary>종목코드_업종코드</summary>
    public string? Code
    {
        get; set;
    }

    /// <summary>단위체결량</summary>
    public int UnitContractAmount
    {
        get; set;
    }

    /// <summary>단위체결가</summary>
    public double UnitContractPrice
    {
        get; set;
    }

    /// <summary>매매구분</summary>
    public string? TradedClassification
    {
        get; set;
    }

    /// <summary>계좌번호</summary>
    public string? AccNo
    {
        get; set;
    }
}
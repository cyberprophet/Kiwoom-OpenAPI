namespace ShareInvest.Interface;

public class Quote
{
    /// <summary>현재가</summary>
    public decimal CurrentPrice
    {
        get; set;
    }
    /// <summary>(최우선)매도호가</summary>
    public decimal TopPriorityAskPrice
    {
        get; set;
    }
    /// <summary>(최우선)매수호가</summary>
    public decimal TopPriorityBidPrice
    {
        get; set;
    }
}
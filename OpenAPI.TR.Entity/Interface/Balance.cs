namespace ShareInvest.Interface;

public class Balance
{
    /// <summary>보유수량</summary>
    public int HoldingQuantity
    {
        get; set;
    }

    /// <summary>주문가능수량</summary>
    public int QuantityAvailableForOrder
    {
        get; set;
    }

    /// <summary>매도_매수구분</summary>
    public OrderStatus OrderStatus
    {
        get; set;
    }

    /// <summary>당일순매수량</summary>
    public int TransactionQuantity
    {
        get; set;
    }

    /// <summary>당일총매도손익</summary>
    public long TradingProfit
    {
        get; set;
    }

    /// <summary>계좌번호</summary>
    public string? AccNo
    {
        get; set;
    }
}
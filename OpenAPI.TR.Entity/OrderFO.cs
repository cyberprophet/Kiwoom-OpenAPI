namespace ShareInvest;

public class OrderFO
{
    /// <summary>사용자 구분명</summary>
    public virtual string? RQName
    {
        get; set;
    }

    /// <summary>화면번호</summary>
    public virtual string ScreenNo
    {
        get => (count++ % 0x20 + 9000).ToString("D4");
    }

    /// <summary>계좌번호 10자리</summary>
    public virtual string? AccNo
    {
        get; set;
    }

    /// <summary>종목코드</summary>
    public virtual string? Code
    {
        get; set;
    }

    /// <summary>
    /// 주문종류
    /// 1.신규매매
    /// 2.정정
    /// 3.취소
    /// </summary>
    public virtual int OrdKind
    {
        set
        {
            ordKind = value;
        }
        get => ordKind;
    }

    /// <summary>
    /// 매매구분
    /// 1.매도
    /// 2.매수
    /// </summary>
    public virtual string? SlbyTp
    {
        get; set;
    }

    /// <summary>
    /// 거래구분
    /// 1.지정가
    /// 2.조건부지정가
    /// 3.시장가
    /// 4.최유리지정가
    /// 5.지정가(IOC)
    /// 6.지정가(FOK)
    /// 7.시장가(IOC)
    /// 8.시장가(FOK)
    /// 9.최유리지정가(IOC)
    /// A.최유리지정가(FOK)
    /// </summary>
    public virtual string OrdTp
    {
        set
        {
            ordType = value;
        }
        get => ordType;
    }

    /// <summary>주문수량</summary>
    public virtual int Qty
    {
        set
        {
            quantity = value;
        }
        get => quantity;
    }

    /// <summary>주문가격</summary>
    public virtual string Price
    {
        set
        {
            price = value;
        }
        get => price;
    }

    /// <summary>
    /// 신규주문에는 공백입력,
    /// 정정/취소시 원주문번호를 입력합니다.
    /// </summary>
    public virtual string OrgOrdNo
    {
        set
        {
            ordNo = value;
        }
        get => ordNo;
    }

    public virtual string? Strategics
    {
        get; set;
    }

    int quantity = 1;
    int ordKind = 1;

    string ordNo = string.Empty;
    string ordType = "1";
    string price = "0.01";

    static uint count;
}
namespace ShareInvest;

public class Order
{
    /// <summary>사용자 구분명</summary>
    public virtual string? RQName
    {
        get; set;
    }

    /// <summary>화면번호</summary>
    public virtual string ScreenNo
    {
        get => (count++ % 0x30 + 1000).ToString("D4");
    }

    /// <summary>계좌번호 10자리</summary>
    public virtual string? AccNo
    {
        get; set;
    }

    /// <summary>
    /// 주문유형
    /// 1.신규매수
    /// 2.신규매도
    /// 3.매수취소
    /// 4.매도취소
    /// 5.매수정정
    /// 6.매도정정
    /// 7.프로그램매매 매수
    /// 8.프로그램매매 매도
    /// </summary>
    public virtual int OrderType
    {
        set
        {
            ordType = value;
        }
        get => ordType;
    }

    /// <summary>종목코드 (6자리)</summary>
    public virtual string? Code
    {
        get; set;
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
    public virtual int Price
    {
        get; set;
    }

    /// <summary>
    /// 거래구분
    /// 00.지정가
    /// 03.시장가
    /// 05.조건부지정가
    /// 06.최유리지정가
    /// 07.최우선지정가
    /// 10.지정가IOC
    /// 13.시장가IOC
    /// 16.최유리IOC
    /// 20.지정가FOK
    /// 23.시장가FOK
    /// 26.최유리FOK
    /// 61.장전시간외종가
    /// 62.시간외단일가매매
    /// 81.장후시간외종가
    /// </summary>
    public virtual string HogaGb
    {
        set
        {
            hogaGb = value;
        }
        get => hogaGb;
    }

    /// <summary>
    /// 신규주문에는 공백입력,
    /// 정정/취소시 원주문번호를 입력합니다.
    /// </summary>
    public virtual string OrgOrderNo
    {
        set
        {
            ordNo = value;
        }
        get => ordNo;
    }

    int quantity = 1;
    int ordType = 1;

    string ordNo = string.Empty;
    string hogaGb = "00";

    static uint count;
}
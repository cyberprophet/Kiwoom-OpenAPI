using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종프로그램요청</summary>
public class OPT10010 : TR
{
    /// <summary>업종프로그램</summary>
    [DataMember, JsonProperty("업종프로그램")]
    public MultiOPT10010[]? MultiResponse
    {
        get; set;
    }

    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => ["종목코드"];

    public override string[]? Value
    {
        get; set;
    }

    public override string? RQName
    {
        set
        {

        }
        get => "업종프로그램요청";
    }

    public override string TrCode
    {
        get => nameof(OPT10010);
    }

    public override int PrevNext
    {
        get; set;
    }

    public override string ScreenNo
    {
        get => LookupScreenNo;
    }

    public override string[] Single => [];

    public override string[] Multiple => ["차익위탁매도수량", "차익위탁매도금액", "차익위탁매수수량", "차익위탁매수금액", "차익위탁순매수수량", "차익위탁순매수금액", "비차익위탁매도수량", "비차익위탁매도금액", "비차익위탁매수수량", "비차익위탁매수금액", "비차익위탁순매수수량", "비차익위탁순매수금액", "전체차익위탁매도수량", "전체차익위탁매도금액", "전체차익위탁매수수량", "전체차익위탁매수금액", "전체차익위탁순매수수량", "전체차익위탁순매수금액"];
}
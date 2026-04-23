namespace ShareInvest;

public abstract class TR
{
    public abstract string[] Id
    {
        get;
    }

    public abstract string[]? Value
    {
        get; set;
    }

    public abstract string? RQName
    {
        get; set;
    }

    public abstract string TrCode
    {
        get;
    }

    public abstract int PrevNext
    {
        get; set;
    }

    public abstract string ScreenNo
    {
        get;
    }

    public abstract string[] Single
    {
        get;
    }

    public abstract string[] Multiple
    {
        get;
    }

    protected internal virtual string LookupScreenNo
    {
        get => (count++ % 0x40 + 3000).ToString("D4");
    }

    static uint count;
}
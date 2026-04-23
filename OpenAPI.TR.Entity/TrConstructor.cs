using ShareInvest.OpenAPI.Entity;

using System.Globalization;
using System.Reflection;
using System.Text;

namespace ShareInvest;

public static class TrConstructor
{
    public static IEnumerable<TR> GetInventoryOnConditions(IEnumerable<string> enumerable)
    {
        int index = 0;
        var sb = new StringBuilder(0x100);
        var codeStack = new Stack<StringBuilder>(0x10);

        foreach (var code in enumerable)
        {
            if (string.IsNullOrEmpty(code) is false)
            {
                if (index++ % 0x63 == 0x62)
                {
                    codeStack.Push(sb.Append(code));

                    sb = new StringBuilder();
                }
                sb.Append(code).Append(';');
            }
        }
        codeStack.Push(sb.Remove(sb.Length - 1, 1));

        while (codeStack.TryPop(out StringBuilder? pop))
        {
            if (pop is not null && pop.Length > 5)
            {
                var listOfStocks = pop.ToString();

                yield return new OPTKWFID
                {
                    Value = [listOfStocks],
                    PrevNext = listOfStocks.Split(';').Length
                };
            }
        }
    }

    public static CultureInfo Culture
    {
        get => new("ko-KR");
    }

    public static Assembly Assembly
    {
        get => Assembly.GetExecutingAssembly();
    }

    public static bool EventOccursInStock(string? currentPrice)
    {
        var now = DateTime.Now;

        return string.IsNullOrEmpty(currentPrice) is false && now.Hour > 5 && now.Hour < 8 && now.DayOfWeek != DayOfWeek.Sunday && now.DayOfWeek != DayOfWeek.Saturday;
    }
}
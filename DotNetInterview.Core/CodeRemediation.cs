using DotNetInterview.Core.Entities;

namespace DotNetInterview.Core;

public static class CodeRemediation
{
    /// <summary>
    /// Code returns the Sum of OpenBalances Sum(Entries[GrandTotal - AmountPaid])
    /// </summary>
    /// <param name="Orders"></param>
    /// <returns></returns>
    public static decimal GetOpenBalanceTotals(List<OrderModel> Orders)
    {
        var total = 0m;

        foreach (var order in Orders)
        {
            if (order.GrandTotal > order.AmountPaid && order.CreatedDate < DateTime.Today)
            {
                total += (order.GrandTotal - order.AmountPaid);
            }
        }

        return total;
    }

    /// <summary>
    /// Code returns the Sum of OpenBalances older than 30 days using
    /// Sum(Entries[GrandTotal - AmountPaid])
    /// </summary>
    /// <param name="Orders"></param>
    /// <returns></returns>
    public static decimal GetOpenBalanceTotalsPast30(List<OrderModel> Orders)
    {
        var total = 0m;

        foreach (var order in Orders)
        {
            if (order.GrandTotal > order.AmountPaid && order.CreatedDate < DateTime.Today.AddDays(-30))
            {
                total += (order.GrandTotal - order.AmountPaid);
            }
        }

        return total;
    }

    /// <summary>
    /// Code returns the Sum of OpenBalances older than 60 days using
    /// Sum(Entries[GrandTotal - AmountPaid])
    /// </summary>
    /// <param name="Orders"></param>
    /// <returns></returns>
    public static decimal GetOpenBalanceTotalsPast60(List<OrderModel> Orders)
    {
        var total = 0m;

        foreach (var order in Orders)
        {
            if (order.GrandTotal > order.AmountPaid && order.CreatedDate < DateTime.Today.AddDays(-60))
            {
                total += (order.GrandTotal - order.AmountPaid);
            }
        }

        return total;
    }

    /// <summary>
    /// Code returns the Sum of OpenBalances older than 90 days using
    /// Sum(Entries[GrandTotal - AmountPaid])
    /// </summary>
    /// <param name="Orders"></param>
    /// <returns></returns>
    public static decimal GetOpenBalanceTotalsPast90(List<OrderModel> Orders)
    {
        var total = 0m;

        foreach (var order in Orders)
        {
            if (order.GrandTotal > order.AmountPaid && order.CreatedDate < DateTime.Today.AddDays(-90))
            {
                total += (order.GrandTotal - order.AmountPaid);
            }
        }

        return total;
    }
}

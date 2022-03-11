using DotNetInterview.Core;
using DotNetInterview.Core.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DotNetInterview.Tests;

[TestClass]
public class CodeRemediationTests
{
    private List<OrderModel> _orders;

    public CodeRemediationTests()
    {
        var client1 = new ClientModel
        {
            Id = 1,
            FirstName = "Abby",
            LastName = "Alpha"
        };
        var client2 = new ClientModel
        {
            Id = 2,
            FirstName = "Bobby",
            LastName = "Beta"
        };
        var client3 = new ClientModel
        {
            Id = 3,
            FirstName = "Charlie",
            LastName = "Charles"
        };

        _orders = new List<OrderModel>()
            {
                new OrderModel
                {
                    Id = 100,
                    Client = client1,
                    CreatedDate = System.DateTime.Today.AddDays(-5),
                    OrderNumber = "1000",
                    GrandTotal = 5000.00m,
                    AmountPaid = 0m
                },
                new OrderModel
                {
                    Id = 101,
                    Client = client1,
                    CreatedDate = System.DateTime.Today,
                    OrderNumber = "1001",
                    GrandTotal = 2500.00m,
                    AmountPaid = 2000.00m
                },
                new OrderModel
                {
                    Id = 102,
                    Client = client2,
                    CreatedDate = System.DateTime.Today.AddDays(-35),
                    OrderNumber = "1002",
                    GrandTotal = 1000.00m,
                    AmountPaid = 250m
                },
                new OrderModel
                {
                    Id = 103,
                    Client = client2,
                    CreatedDate = System.DateTime.Today.AddDays(-40),
                    OrderNumber = "1002",
                    GrandTotal = 1000.00m,
                    AmountPaid = 350m
                },
                new OrderModel
                {
                    Id = 104,
                    Client = client3,
                    CreatedDate = System.DateTime.Today.AddDays(-65),
                    OrderNumber = "1002",
                    GrandTotal = 1000.00m,
                    AmountPaid = 250m
                },
                new OrderModel
                {
                    Id = 105,
                    Client = client3,
                    CreatedDate = System.DateTime.Today.AddDays(-90),
                    OrderNumber = "1002",
                    GrandTotal = 1000.00m,
                    AmountPaid = 150m
                }
            };
    }

    [TestMethod]
    public void DotNetInterview_Core_CodeRemediation_RemainingAmount_AddsCorrectly()
    {
        var grandTotal = _orders.Where(a => a.CreatedDate < System.DateTime.Today).Sum(a => (a.GrandTotal - a.AmountPaid));

        var resultTotal = CodeRemediation.GetOpenBalanceTotals(_orders);

        Assert.AreEqual(grandTotal, resultTotal);
    }

    [TestMethod]
    public void DotNetInterview_Core_CodeRemediation_GetOpenBalanceTotalsPast30_AddsCorrectly()
    {
        var grandTotal = _orders.Where(a => a.CreatedDate < System.DateTime.Today.AddDays(-30)).Sum(a => (a.GrandTotal - a.AmountPaid));

        var resultTotal = CodeRemediation.GetOpenBalanceTotalsPast30(_orders);

        Assert.AreEqual(grandTotal, resultTotal);
    }

    [TestMethod]
    public void DotNetInterview_Core_CodeRemediation_GetOpenBalanceTotalsPast60_AddsCorrectly()
    {
        var grandTotal = _orders.Where(a => a.CreatedDate < System.DateTime.Today.AddDays(-60)).Sum(a => (a.GrandTotal - a.AmountPaid));

        var resultTotal = CodeRemediation.GetOpenBalanceTotalsPast60(_orders);

        Assert.AreEqual(grandTotal, resultTotal);
    }

    [TestMethod]
    public void DotNetInterview_Core_CodeRemediation_GetOpenBalanceTotalsPast90_AddsCorrectly()
    {
        var grandTotal = _orders.Where(a => a.CreatedDate < System.DateTime.Today.AddDays(-90)).Sum(a => (a.GrandTotal - a.AmountPaid));

        var resultTotal = CodeRemediation.GetOpenBalanceTotalsPast90(_orders);

        Assert.AreEqual(grandTotal, resultTotal);
    }
}

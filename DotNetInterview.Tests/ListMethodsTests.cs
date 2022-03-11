using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DotNetInterview.Tests;

[TestClass]
public class ListMethodsTests
{
    private readonly int[] _unsortedNumbers = new int[15] { 510, 320, 240, 12, 7, 300, 241, 420, 8042, 1104, 294, 2, 0, 7, 99 };
    private readonly int[] _sortedNumbers = new int[15] { 0, 2, 7, 7, 12, 99, 240, 241, 294, 300, 320, 420, 510, 1104, 8042 };

    [TestMethod]
    public void DotNetInterview_Core_ListMethods_SortNumbers_SortsCorrectly()
    {
        var result = DotNetInterview.Core.ListMethods.SortNumbers(_unsortedNumbers).ToArray();

        CollectionAssert.AreEqual(_sortedNumbers, result);
    }

    [TestMethod]
    public void DotNetInterview_Core_ListMethods_GetNthLargestElement_Gets2ndLargestCorectly()
    {
        var answer = 1104;

        var result = Core.ListMethods.GetNthLargestElement(_unsortedNumbers, 2);

        Assert.AreEqual(answer, result);
    }

    [TestMethod]
    public void DotNetInterview_Core_ListMethods_GetNthLargestElement_GetsNthBeyondRange()
    {
        var answer = -1;
        var result = Core.ListMethods.GetNthLargestElement(_unsortedNumbers, _unsortedNumbers.Count());

        Assert.AreEqual(answer, result);
    }
}
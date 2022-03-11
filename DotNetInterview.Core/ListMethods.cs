namespace DotNetInterview.Core;

public static class ListMethods
{
    /// <summary>
    /// Given a list of numbers, return the List, sorted
    /// </summary>
    /// <param name="unsortedNumbers"></param>
    /// <returns></returns>
    public static IEnumerable<int> SortNumbers(IEnumerable<int> unsortedNumbers)
    {
        return unsortedNumbers;
    }

    /// <summary>
    /// Given a List of Numbers, get the nthLargest number
    /// Example: Given Array { 1, 3, 8, 10, 15 }, return the 2nd Largest Number: 10
    /// Example 2: Given Array { 1, 3, 8, 10, 15 }, return the 6th Largest Number breaks, return -1
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="nthLargest"></param>
    /// <returns></returns>
    public static int GetNthLargestElement(IEnumerable<int> numbers, int nthLargest)
    {
        return numbers.First();
    }

    /// <summary>
    /// Given two Lists of type T, merge the contents into a single list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="ListA"></param>
    /// <param name="ListB"></param>
    /// <returns></returns>
    public static IEnumerable<T> MergeLists<T>(IEnumerable<T> ListA, IEnumerable<T> ListB)
    {
        return null;
    }
}
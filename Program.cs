using System;
using System.Collections.Generic;
namespace CompareTwoList
{
    class Program
    {
        static List<int> FindMissingVals(int[] firstArr,int[] secondArr)
        {
            List<int> missingVals = new List<int>();
            List<int> mutualVals = new List<int>();
            HashSet<int> secondArrItems = new HashSet<int>();

            foreach (var item in secondArr)
            {
                secondArrItems.Add(item);
            }
            foreach (var item in firstArr)
            {
                if (!secondArrItems.Contains(item))
                {
                    missingVals.Add(item);
                }
                else
                {
                    mutualVals.Add(item);
                }
            }
            return missingVals;
        }

        static void Main(string[] args)
        {
            FindMissingVals(new int [] {1,2,3,4,5,6,7},new int [] {4,5,6,7,8,9,0}).ForEach(Console.WriteLine);
        }
    }
}

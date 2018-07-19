using System;
using System.Collections.Generic;

namespace TrainingProjects
{
    public class Program
    {
        public static void Main()
        {
            
        }
        public int ListSimpleSearch(int[] arr, int find)
        {
            KListSimpleSearch<int> L = new KListSimpleSearch<int>();
            return L.ListSearch(arr, find);
        }
    }
}
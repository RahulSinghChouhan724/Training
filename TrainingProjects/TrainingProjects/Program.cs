using System;
using System.Collections.Generic;

namespace TrainingProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public int ListSimpleSearch(float[] arr, float find)
        {
            List<float> Li = new List<float>();
            for (int i = 0; i < arr.Length; i++)
                Li.Add(arr[i]);
            KListSimpleSearch L = new KListSimpleSearch();
            int Result = L.Search(Li, find);
            return Result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class KListSimpleSearch<T>
    {
        public static T Li { get; set; }

        public int ListMaker(T[] arr, T find)
        {
            KListSimpleSearch<T> L = new KListSimpleSearch<T>();
            List<T> Li = new List<T>();
            for (int i = 0; i < arr.Length; i++)
                Li.Add(arr[i]);
            return L.ListSearch(Li, find);
        }

        public int ListSearch(List<T> Li, T find)
        {
            for (int i = 0; i < Li.Count; i++)
            {
                if (Li[i] is String)
                    if (Li[i].Equals(find))
                        return i;
                    else;
                else if ((float.Parse(Li[i].ToString())).Equals(float.Parse(find.ToString())))
                    return i;
            }
            return -1;
        }
    }
}

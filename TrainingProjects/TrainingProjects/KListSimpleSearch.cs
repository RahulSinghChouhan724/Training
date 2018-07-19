using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class KListSimpleSearch
    {
        public int SearchNumber(List<float> Li, float find)
        {
            for (int i = 0; i < Li.Count; i++)
            {
                if (Li[i].Equals(find))
                    return i;
            }
            return -1;
        }
        public int SearchString(List<String> Li, String find)
        {
            for (int i = 0; i < Li.Count; i++)
            {
                if (Li[i].Equals(find))
                    return i;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    class DictionarySorting
    {
        public void PopulateDict(string key, int id, string name)
        {
            Dictionary<string, Student> dict = new Dictionary<string, Student>();
            Student S = new Student(id, name);
            dict.Add(key, S);

        }
        public void SortDictionary(Dictionary<string, Student> dict)
        {
            var Sorteddict = dict.OrderBy(x => x.Key);
           
        }
        public int DictionaryTest(string find, Dictionary<string, Student> dict)
        {

            Student Sdict;
            if (dict.TryGetValue(find, out Sdict))
                return Sdict.Id;
            else
                return -1;

        } 
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class SearchDictionaryOfObjects
    {
        public Dictionary<string, Course> D = new Dictionary<string, Course>();
        public void Populate(string Code, int Id, string Name, string Desc)
        {
            Course C = new Course(Id, Name, Desc);
            D.Add(Code, C);
        }
        public int Search(String Find)
        {
            Course Result;
            if (D.TryGetValue(Find, out Result))
                return Result.Id;
            else
                return -1;
        }
    }
}

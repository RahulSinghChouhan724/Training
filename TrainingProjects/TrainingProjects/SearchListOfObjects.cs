using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class ListOfObjects <T>
    {
        List<Course> CLi = new List<Course>();
        public void Populate(int Id, String Name, String Desc)
        {
            Course C = new Course(Id, Name, Desc);
            CLi.Add(C);
        }
        public int Search(T Find)
        {
            for (int i = 0; i < CLi.Count; i++)
            {
                if (Find is String)
                    if (CLi[i].Name.Equals(Find))

                        return i;
                    else;
                else if (CLi[i].Id.Equals(Find))
                    return i;
            }
            return -1;
        }
    }
}
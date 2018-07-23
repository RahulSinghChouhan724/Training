using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class SortList
    {
        List<Student> SList = new List<Student>();

        public void populate(int id, string name)
        {
            Student n = new Student(id, name);
            SList.Add(n);
            //SortListUsingName(SList);
            //SortListUsingId(SList);
            
        }
        public void SortListUsingId()
        {
            // using linq function
            SList.Sort((x, y) => x.Id.CompareTo(y.Id));
        }
        public void SortListUsingName()
        {
            // using linq function
            SList.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public int Test1(int i,int f)
        {
            if(SList[i].Id.Equals(f))
             return 1;
            return -1;
        }
    }
}

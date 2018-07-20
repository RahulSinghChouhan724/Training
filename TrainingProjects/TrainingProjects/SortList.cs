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

        public List<Student> populate(int id, string name)
        {
            Student n = new Student(id, name);
            SList.Add(n);
            //SortListUsingName(SList);
            //SortListUsingId(SList);
            return SList;
        }
        public void SortListUsingId()
        {
            SList.Sort((x, y) => x.Id.CompareTo(y.Id));
        }
        public void SortListUsingName()
        {
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

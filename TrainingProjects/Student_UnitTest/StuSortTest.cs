using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace Student_UnitTest
{
    [TestClass]
    public class StuSortTest
    {
        [TestMethod]
        public void FunctionToCheckValuesAreSortedUsingName()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingName();
            Assert.AreEqual(TestList.Test1(2, 1), 1);
                    
        }
        [TestMethod]
        public void FunctionToCheckValuesAreSortedUsingNameonIndexThree()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingName();
            Assert.AreEqual(TestList.Test1(3, 2), 1);
                    
        }
        [TestMethod]
        public void FunctionToCheckValuesAreSortedUsingNegativeCheck()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingName();
            Assert.AreEqual(TestList.Test1(0, 2), 1);
                    
        }
        [TestMethod]
        public void FunctionToCheckValuesAreSortedUsingId()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingId();
            Assert.AreEqual(TestList.Test1(0, 1), 1);
                    
        }[TestMethod]
        public void FunctionToCheckValuesAreSortedUsingIdOnIndexTwo()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingId();
            Assert.AreEqual(TestList.Test1(2, 3), 1);
                    
        }
        [TestMethod]
        public void FunctionToCheckValuesAreSortedUsingIdNegativeCheck()
        {
            var TestList = new SortList();
            TestList.populate(3,"JvbCJH");
            TestList.populate(2, "xyz");
            TestList.populate(4, "FREc");
            TestList.populate(1, "wsd");
            TestList.SortListUsingId();
            Assert.AreEqual(TestList.Test1(4, 1), 1);
                    
        }

    }
}

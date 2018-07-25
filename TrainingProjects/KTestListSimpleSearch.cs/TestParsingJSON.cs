using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace KTestListSimpleSearch.cs
{
    [TestClass]
    public class TestParsingJSON
    {
        [TestMethod]
        public void TestMethod1()
        {
            Course C1 = new Course(101, "BCA", "Basics of computers.");
  //        Course C2 = new Course(202, "MBA", "Managing stuff.");
  //        Course C3 = new Course(303, "MCom", "Commercial stuff.");
  
            ParsingJSON P = new ParsingJSON();
            Assert.AreEqual(P.Parser(C1), 101);


        }
    }
}

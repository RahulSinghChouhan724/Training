using System;
using TrainingProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Student_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TheFuynctionShouldReturnNameOfstudent()
        {
            Student s1 = new Student(1, "abc");
            Student s2 = new Student(2, "xyz");
            Student s3 = new Student(3, "efg");

            Serialization S = new Serialization();
            Assert.AreEqual(S.serialization(s1),"abc");
        }
        [TestMethod]
        public void TheFuynctionShouldReturnIdOfstudent()
        {
            Student s1 = new Student(1, "abc");
            Student s2 = new Student(2, "xyz");
            Student s3 = new Student(3, "efg");

            Serialization S = new Serialization();
            Assert.AreEqual(S.serialization(s1),01);
        }
        [TestMethod]
        public void TheFuynctionShoulWorkWithMultipleObjectOfstudent()
        {
            Student s1 = new Student(1, "abc");
            Student s2 = new Student(2, "xyz");
            Student s3 = new Student(3, "efg");

            Serialization S = new Serialization();
            Assert.AreEqual(S.serialization(s2),02);
        }
    }
}

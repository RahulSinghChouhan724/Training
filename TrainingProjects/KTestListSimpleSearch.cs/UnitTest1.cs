
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace KTestListSimpleSearch.cs
{
    [TestClass]
    public class UnitTest1
    {
        // Integer tests
        [TestMethod]
        public void ShouldFind4AtIndex4()
        {
            Program P = new Program();
            int[] TestArray = new int []{ 2, 5, 1, 8, 4, 9, 3 };
            var Working = P.ListSimpleSearch(TestArray, 4);
            Assert.AreEqual(Working, 4);
        }
        [TestMethod]
        public void ShouldFind5AtIndex1()
        {
            Program P = new Program();
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = P.ListSimpleSearch(TestArray, 5);
            Assert.AreEqual(Working, 1);
        }
        [TestMethod]
        public void ShouldFindErrorForFinding6()
        {
            Program P = new Program();
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = P.ListSimpleSearch(TestArray, 6);
            Assert.AreEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldFind3AtIndex6()
        {
            Program P = new Program();
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = P.ListSimpleSearch(TestArray, 3);
            Assert.AreEqual(Working, 6);
        }

        // Float tests
        [TestMethod]
        public void ShouldFind2_1AtIndex0()
        {
            Program P = new Program();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = P.ListSimpleSearch(TestArray, 2.1f);
            Assert.AreEqual(Working, 0);
        }
        [TestMethod]
        public void ShouldFind1AtIndex2()
        {
            Program P = new Program();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = P.ListSimpleSearch(TestArray, 1);
            Assert.AreEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldFindErrorForFinding4()
        {
            Program P = new Program();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = P.ListSimpleSearch(TestArray, 4);
            Assert.AreEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldFind3_0AtIndex6()
        {
            Program P = new Program();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = P.ListSimpleSearch(TestArray, 3);
            Assert.AreEqual(Working, 6);
        }
    }
}

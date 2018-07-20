
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace KTestListSimpleSearch
{
    [TestClass]
    public class KTestListSimpleSearch
    {
        // Integer tests
        [TestMethod]
        public void ShouldFind4AtIndex4()
        {
            KListSimpleSearch<int> K = new KListSimpleSearch<int>(); 
            int[] TestArray = new int []{ 2, 5, 1, 8, 4, 9, 3 };
            var Working = K.ListMaker(TestArray, 4);
            Assert.AreEqual(Working, 4);
        }
        [TestMethod]
        public void ShouldFind5AtIndex1()
        {
            KListSimpleSearch<int> K = new KListSimpleSearch<int>(); 
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = K.ListMaker(TestArray, 5);
            Assert.AreEqual(Working, 1);
        }
        [TestMethod]
        public void ShouldNotFind6AtIndex2()
        {
            KListSimpleSearch<int> K = new KListSimpleSearch<int>(); 
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = K.ListMaker(TestArray, 4);
            Assert.AreNotEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldFind3AtIndex6()
        {
            KListSimpleSearch<int> K = new KListSimpleSearch<int>(); 
            int[] TestArray = new int[] { 2, 5, 1, 8, 4, 9, 3 };
            var Working = K.ListMaker(TestArray, 3);
            Assert.AreEqual(Working, 6);
        }

        // Float tests
        [TestMethod]
        public void ShouldFind2_1AtIndex0()
        {
            KListSimpleSearch<float> K = new KListSimpleSearch<float>();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = K.ListMaker(TestArray, 2.1f);
            Assert.AreEqual(Working, 0);
        }
        [TestMethod]
        public void ShouldFind1AtIndex2()
        {
            KListSimpleSearch<float> K = new KListSimpleSearch<float>();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = K.ListMaker(TestArray, 1);
            Assert.AreEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldNotFind4AtIndex2()
        {
            KListSimpleSearch<float> K = new KListSimpleSearch<float>();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = K.ListMaker(TestArray, 4);
            Assert.AreNotEqual(Working, 2);
        }
        [TestMethod]
        public void ShouldFind3_0AtIndex6()
        {
            KListSimpleSearch<float> K = new KListSimpleSearch<float>();
            float[] TestArray = new float[] { 2.1f, 5.9f, 1.0f, 8, 4.4f, 9.7f, 3 };
            var Working = K.ListMaker(TestArray, 3);
            Assert.AreEqual(Working, 6);
        }

        // String tests
        [TestMethod]
        public void ShouldFindRobocopAtIndex3()
        {
            KListSimpleSearch<String> K = new KListSimpleSearch<String>();
            String[] TestArray = new String[] { "Work", "No", "Wassup", "Robocop", "Kulcha", "Boom" };
            var Working = K.ListMaker(TestArray, "Robocop");
            Assert.AreEqual(Working, 3);
        }
        [TestMethod]
        public void ShouldFindWorkAtIndex0()
        {
            KListSimpleSearch<String> K = new KListSimpleSearch<String>();
            String[] TestArray = new String[] { "Work", "No", "Wassup", "Robocop", "Kulcha", "Boom" };
            var Working = K.ListMaker(TestArray, "Work");
            Assert.AreEqual(Working, 0);
        }
        [TestMethod]
        public void ShouldNotFindHeyAtIndex3()
        {
            KListSimpleSearch<String> K = new KListSimpleSearch<String>();
            String[] TestArray = new String[] { "Work", "No", "Wassup", "Robocop", "Kulcha", "Boom" };
            var Working = K.ListMaker(TestArray, "Hey");
            Assert.AreNotEqual(Working, 3);
        }
        [TestMethod]
        public void ShouldFindBoomAtIndex5()
        {
            KListSimpleSearch<String> K = new KListSimpleSearch<String>();
            String[] TestArray = new String[] { "Work", "No", "Wassup", "Robocop", "Kulcha", "Boom" };
            var Working = K.ListMaker(TestArray, "Boom");
            Assert.AreEqual(Working, 5);
        }
    }
}
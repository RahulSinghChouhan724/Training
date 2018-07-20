using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace KTestListSimpleSearch.cs
{
    [TestClass]
    public class TestSearchListOfObjects
    {
        // ID Tests

        [TestMethod]
        public void ShouldFind202AtIndex1()
        {
            ListOfObjects<int> L = new ListOfObjects<int>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search(202), 1);
        }
        [TestMethod]
        public void ShouldFind101AtIndex0()
        {
            ListOfObjects<int> L = new ListOfObjects<int>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search(101), 0);
        }
        [TestMethod]
        public void ShouldFind505AtIndex4()
        {
            ListOfObjects<int> L = new ListOfObjects<int>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search(505), 4);
        }
        [TestMethod]
        public void ShouldNotFind404AtIndex2()
        {
            ListOfObjects<int> L = new ListOfObjects<int>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreNotEqual(L.Search(404), 2);
        }
        [TestMethod]
        public void ShouldNotFind707AtIndex3()
        {
            ListOfObjects<int> L = new ListOfObjects<int>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreNotEqual(L.Search(707), 3);
        }

        // Name Tests

        [TestMethod]
        public void ShouldFindFreeLectureAtIndex3()
        {
            ListOfObjects<String> L = new ListOfObjects<String>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search("Free lecture"), 3);
        }
        [TestMethod]
        public void ShouldFindEconomicsAtIndex0()
        {
            ListOfObjects<String> L = new ListOfObjects<String>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search("Economics"), 0);
        }
        [TestMethod]
        public void ShouldFindArtAtIndex4()
        {
            ListOfObjects<String> L = new ListOfObjects<String>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreEqual(L.Search("Art"), 4);
        }
        [TestMethod]
        public void ShouldNotFindFinanceAtIndex1()
        {
            ListOfObjects<String> L = new ListOfObjects<String>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreNotEqual(L.Search("Finance"), 1);
        }
        [TestMethod]
        public void ShouldNotFindBiologyAtIndex3()
        {
            ListOfObjects<String> L = new ListOfObjects<String>();
            L.Populate(101, "Economics", "How money flows around in an economy.");
            L.Populate(202, "Biology", "Machinery inside animals that keeps them alive.");
            L.Populate(303, "Mathematics", "Numbers working with other numbers to make more numbers.");
            L.Populate(404, "Free lecture", "Everyone's favourite, for obvious reasons.");
            L.Populate(505, "Art", "Throwing colours around and pretending to be an artist.");
            Assert.AreNotEqual(L.Search("Biology"), 3);
        }
    }
}

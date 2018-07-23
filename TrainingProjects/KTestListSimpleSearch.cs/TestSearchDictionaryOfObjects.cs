using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingProjects;

namespace KTestListSimpleSearch.cs
{
    [TestClass]
    public class TestSearchDictionaryOfObjects
    {
        [TestMethod]
        public void ShouldFindMBAWithCode404()
        {
            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects();
            S.Populate("BCA", 101, "Bachelor Of Computer Apps", "Basics of computer workings.");
            S.Populate("MCA", 202, "Master Of Computer Apps", "Basics of computer workings, but pretending to be more.");
            S.Populate("BBA", 303, "Bachelor Of Business Administration", "Basics of managing business.");
            S.Populate("MBA", 404, "Master Of Business Administration", "Advanced business management.");
            S.Populate("PhD", 505, "Doctor of Philosophy", "Big stuff I don't understand.");
            Assert.AreEqual(S.Search("MBA"), 404);
        }
        [TestMethod]
        public void ShouldFindMBAWithCode404_v2()
        {


            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects
            {
                D = new System.Collections.Generic.Dictionary<string, Course>
                {
                    { "BCA", new Course{ Id = 101, Name = "Bachelor Of Computer Apps", Desc = "Basics of computer workings." } }
                    ,{ "MCA", new Course{ Id = 202, Name = "Master Of Computer Apps", Desc = "Basics of computer workings, but pretending to be more." } }
                    ,{ "BBA", new Course{ Id = 303, Name = "Bachelor Of Business Administration", Desc = "Basics of managing business." } }
                    ,{ "MBA", new Course{ Id = 404, Name = "Master Of Business Administration", Desc = "Advanced business management." } }
                    ,{ "PhD", new Course{ Id = 505, Name = "Doctor of Philosophy", Desc = "Big stuff I don't understand." } }
                }
            };
            Assert.AreEqual(S.Search("MBA"), 404);
        }

        [TestMethod]
        public void ShouldFindBCAWithCode101()
        {
            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects();
            S.Populate("BCA", 101, "Bachelor Of Computer Apps", "Basics of computer workings.");
            S.Populate("MCA", 202, "Master Of Computer Apps", "Basics of computer workings, but pretending to be more.");
            S.Populate("BBA", 303, "Bachelor Of Business Administration", "Basics of managing business.");
            S.Populate("MBA", 404, "Master Of Business Administration", "Advanced business management.");
            S.Populate("PhD", 505, "Doctor of Philosophy", "Big stuff I don't understand.");
            Assert.AreEqual(S.Search("BCA"), 101);
        }
        [TestMethod]
        public void ShouldFindPhDWithCode505()
        {
            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects();
            S.Populate("BCA", 101, "Bachelor Of Computer Apps", "Basics of computer workings.");
            S.Populate("MCA", 202, "Master Of Computer Apps", "Basics of computer workings, but pretending to be more.");
            S.Populate("BBA", 303, "Bachelor Of Business Administration", "Basics of managing business.");
            S.Populate("MBA", 404, "Master Of Business Administration", "Advanced business management.");
            S.Populate("PhD", 505, "Doctor of Philosophy", "Big stuff I don't understand.");
            Assert.AreEqual(S.Search("PhD"), 505);
        }
        [TestMethod]
        public void ShouldNotFindBScWithCode101()
        {
            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects();
            S.Populate("BCA", 101, "Bachelor Of Computer Apps", "Basics of computer workings.");
            S.Populate("MCA", 202, "Master Of Computer Apps", "Basics of computer workings, but pretending to be more.");
            S.Populate("BBA", 303, "Bachelor Of Business Administration", "Basics of managing business.");
            S.Populate("MBA", 404, "Master Of Business Administration", "Advanced business management.");
            S.Populate("PhD", 505, "Doctor of Philosophy", "Big stuff I don't understand.");
            Assert.AreNotEqual(S.Search("Bsc"), 101);
        }
        [TestMethod]
        public void ShouldNotFindMBAWithCode202()
        {
            SearchDictionaryOfObjects S = new SearchDictionaryOfObjects();
            S.Populate("BCA", 101, "Bachelor Of Computer Apps", "Basics of computer workings.");
            S.Populate("MCA", 202, "Master Of Computer Apps", "Basics of computer workings, but pretending to be more.");
            S.Populate("BBA", 303, "Bachelor Of Business Administration", "Basics of managing business.");
            S.Populate("MBA", 404, "Master Of Business Administration", "Advanced business management.");
            S.Populate("PhD", 505, "Doctor of Philosophy", "Big stuff I don't understand.");
            Assert.AreNotEqual(S.Search("MBA"), 202);
        }
    }
}

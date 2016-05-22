using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyNCVT.DAL;
using MyNCVT.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DALTeacherTitle dtt = new DALTeacherTitle();
            TeacherTitle tt = new TeacherTitle();
            tt.TeacherTitleName = "AA";
            tt.TeacherTitleDescription = "OK";
            Assert.AreEqual(dtt.AddTeacherTitle(tt),true );

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTest
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Alignments topLeft = Alignments.Top | Alignments.Left;
            bool isTopIncluded = (topLeft & Alignments.Top) != 0;
        }

        [TestMethod]
        public void TestMethod2()
        {
            Status status = Status.Created | Status.Confirmed;
            var s1 = status & Status.Confirmed;
            Status s2 = (Status)10;

        }

    }
}

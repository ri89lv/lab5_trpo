using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab5
{
    [TestFixture]

    class Class2_test
    {
        [TestCase]        public double inch_to_cm(double n)
        {
            Class1 f = new Class1();
            Assert.AreEqual(12.7, inch_to_cm(5));
            return n;
        }

        [TestCase]        public void parity()
        {
            Class1 f = new Class1();
            Assert.IsTrue(f.parity(2));
            Assert.IsFalse(f.parity(3));
        }

        [TestCase]        public void max_value()
        {
            Class1 f = new Class1();
        }

        [TestCase]        public void division()
        {
            Class1 f = new Class1();
        }

    }
}

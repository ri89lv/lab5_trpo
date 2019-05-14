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
        [TestCase]
        public void inch_to_cm()
        {
            Class1 f = new Class1();
            //Assert.AreEqual(12.7, f.inch_to_cm(5));
            
            var ex = Assert.Throws<ArgumentException>(() => f.inch_to_cm(-5));
            
            Assert.That(ex.Message, Is.EqualTo("Некорректный ввод. Введено отрицательное число."));

            var ex2 = Assert.Throws<ArgumentException>(() => f.inch_to_cm(double.MaxValue));
            Assert.That(ex2.Message, Is.EqualTo("Некорректный ввод. Выход за пределы допустимого значения."));

            Assert.DoesNotThrow(() => f.inch_to_cm(5));


           
        }

        [TestCase]
        public void parity()
        {
            Class1 f = new Class1();
            Assert.IsTrue(f.parity(2));
            Assert.IsFalse(f.parity(3));
        }

        [TestCase]
        public void max_value()
        {
            Class1 f = new Class1();

            var ex = Assert.Throws<ArgumentException>(() => f.max_value());
        }

        [TestCase]
        public void division()
        {
            Class1 f = new Class1();
            var ex = Assert.Throws<ArgumentException>(() =>  f.division(2, 0));
            
            Assert.That(ex.Message, Is.EqualTo("Некорректный ввод. Делитель равен нулю."));
            
            Assert.DoesNotThrow(() => f.division(2, 1));
        }

    }
}

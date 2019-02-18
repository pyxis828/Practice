using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBoookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Kirstin's grade book.";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Kirstin";
            string name2 = "kirstin";

            bool result = String.Equals(name1, name2, System.StringComparison.CurrentCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual(book1.Name, "A gradebook");
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A gradebook";
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            x = IncrementNumber(x);
            Assert.AreEqual(47, x);
        }

        private int IncrementNumber(int number)
        {
            //Console.WriteLine(number++);
            return number++;
        }
    }
}

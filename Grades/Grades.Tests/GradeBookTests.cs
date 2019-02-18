using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(90, results.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(10, results.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(99);
            book.AddGrade(2);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(70.375, results.AverageGrade);
        }

    }
}

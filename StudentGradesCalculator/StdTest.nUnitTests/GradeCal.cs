using System;
using StudentGradesCalculator;
namespace StdTest.nUnitTests
{
    public class GradeCal
    {
        private Std st { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            st = new Std();
        }

        [Test]
        public void GetGradesByPercentage_Test1()
        {
            var percentage = 91;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("A+",grade);
        }
    }

}
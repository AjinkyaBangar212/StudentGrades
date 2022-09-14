using NUnit.Framework;

namespace StudentGrades.nUnitTests1
{
    public class GradeCalculatorTests
    {

        // youtube Link -https://youtu.be/24ytq8JP2jI


        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();


        }

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            //assign
            var percentage = 70;

            //act 
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);


            //asset
            Assert.AreEqual("C" , grade);
        }
    }
}
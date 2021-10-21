using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void CheckDate()
        {
            MutipleFunction mutipleFunction = new MutipleFunction();
            Assert.IsTrue(mutipleFunction.CheckDate(12, 12, 2021));
        }
        [Test]
        public void DayInMonth()
        {
            MutipleFunction mutipleFunction = new MutipleFunction();
            Assert.IsTrue(41<= mutipleFunction.DayInMonth(2020, 3));
        }
    }
}
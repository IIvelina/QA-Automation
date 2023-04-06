namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_NegativeNumbers()
        {
            int result = Summator.Sum(new int[] { -7, -9 });

            Assert.That(result == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int result = Summator.Sum(new int[] {  });

            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            int expected = Summator.Sum(new int[] { 200000000, 200000000, 200000000 });

            Assert.AreEqual(expected, 600000000);
        }
    }
}
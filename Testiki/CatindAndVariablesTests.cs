namespace domashka.test
{
    public class CatindAndVariablesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(100, 100, 100, 10100)]
        [TestCase(287, 975, 188, 183587)]
        public void DeliveryTest(int rate, int distanceFee, int distance, int expected)
        {

            int actual = CatindAndVariables.Delivery(rate, distanceFee, distance);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, 100, 0)]
        [TestCase(801, 689, 11.2)]
        public void BonusTest(double salesPlan, double profitForTheMonth, double expected)
        {

            double actual = CatindAndVariables.Bonus(salesPlan ,profitForTheMonth);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(100, 100, 200)]
        [TestCase(333, 706, 1039)]
        public void BankTest(double profitForTheMonth, double salesPlan, double expected)
        {

            double actual = CatindAndVariables.Bank(profitForTheMonth, salesPlan);

            Assert.AreEqual(expected, actual);
        }
    }
}
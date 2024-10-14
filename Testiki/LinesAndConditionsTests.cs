using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashka.test
{
    internal class LinesAndConditionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[TestCase(100, 100, 100, 10100)]
        //[TestCase(287, 975, 188, 183587)]
        ////Console.WriteLine("Введите название товара:");
        ////name = Convert.ToString(Console.ReadLine());

        ////Console.WriteLine("Введите стоимость товара:");
        ////price = Convert.ToDouble(Console.ReadLine());

        ////Console.WriteLine("Введите количество товаров:");
        ////quantity = Convert.ToDouble(Console.ReadLine());

        ////Console.WriteLine("Ваш товар участвует в акции? (да/нет)");
        ////promotion = Convert.ToString(Console.ReadLine());
        //public void DeliveryTest(int rate, int distanceFee, int distance, int expected)
        //{

        //    int actual = CatindAndVariables.Delivery(rate, distanceFee, distance);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(2, "Вам подойдёт маленький стол")]
        public void DeliveryTest(double quantity, string expected)
        {

            int actual = LinesAndConditions.SuitableTable(quantity);

            Assert.AreEqual(expected, actual);
        }
    }
}

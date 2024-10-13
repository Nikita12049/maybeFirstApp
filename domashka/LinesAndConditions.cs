namespace domashka
{
    internal class LinesAndConditions
    {



        //                                     второе дз ⬇⬇⬇⬇

        //                                                     задание 1

        public static double Discount(string name, double price, double quantity, string promotion)
        {

            Console.WriteLine("Введите название товара:");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите стоимость товара:");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество товаров:");
            quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ваш товар участвует в акции? (да/нет)");
            promotion = Convert.ToString(Console.ReadLine());


            double discount1 = price * 0.1;

            double discount2 = price * 0.015;

            double result = price;

            if (quantity >= 5)
            {
                result = price - discount1;
            }

            if (promotion == "да")
            {
                result = price - discount2;
            }

            if (quantity >= 5 && promotion == "да")
            {
                result = price - discount1 - discount2;
            }
            return result;
        }

        //                                                      задание 2

        public static string SuitableTable(double quantity)
        {

            Console.WriteLine("Введите количество посетителей:");
            quantity = Convert.ToInt32(Console.ReadLine());

            string answer = "";

            if (quantity <= 2)
            {
                answer = "Вам подойдёт маленький стол";
            }

            else if (quantity > 2 && quantity <= 4)
            {
                answer = "Вам подойдёт средний стол";
            }

            else if (quantity > 4 && quantity <= 8)
            {
                answer = "Вам подойдёт большой стол";
            }
            else
            {
                answer = "Вам придёться оставить кого-то дома";
            }
            return answer;
        }

        //                                                      задание 3
        public static string RegularCustomer(string name, double age, double orders, double promotion)
        {

            Console.WriteLine("Введите ваше имя:");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите ваш возраст:");
            age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество заказов:");
            orders = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сколько вы потратили средств:");
            promotion = Convert.ToDouble(Console.ReadLine());

            string answer = "";

            if (orders >= 4 && promotion >= 5000 || age >= 60)
            {
                answer = "Для вас скидка!";
            }
            else
            {
                answer = "Для вас скидки нет";
            }
            return answer;
        }
        //                                                    задание 4

        public static string CheckingTheGoods(string name, double age, double orders, double promotion)
        {



            Console.WriteLine("Введите длину заказа:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину заказа:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту заказа:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вес заказа:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние до вашего дома:");
            double distance = Convert.ToDouble(Console.ReadLine());

            if (length + width + height > 150)
            {
                Console.WriteLine("Ваш заказ НЕ малогабаритный");
            }

            else if (length > 100 || width > 100 || height > 100)
            {
                Console.WriteLine("Ваш заказ НЕ малогабаритный");
            }

            else if (weight > 10)
            {
                Console.WriteLine("Ваш заказ НЕ малогабаритный");
            }

            else if (distance < 3 || distance > 10)
            {
                Console.WriteLine("Ваш заказ НЕ малогабаритный");
            }
            else
            {
                Console.WriteLine("Ваш заказ малогабаритный");
            }

        }


    }
}

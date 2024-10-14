namespace domashka
{
    internal class SeriesFor
    {
        //                                                   третье дз ⬇⬇⬇⬇

        //                                                      задание 1
        public static double Exponentiation(double number1, double number2)
        {
            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите ещё одно число:");
            //double number2 = Convert.ToDouble(Console.ReadLine());


            for (double i = number1; number2 != 1; number2 -= 1)
            {
                number1 *= i;
            }
            return number1;
        }

        //                                                     задание 2
        public static double Divider(double number1)
        {

            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            for (double i = 1; i < 1000; i++)
            {
                if (number1 % i == 0)
                {
                    //result = Console.WriteLine(i); ⬅ здесь ошибка!!!!!!!
                }
            }
            return number1;
        }

        //                                                    задание 3

        public static double NumbersWhoseSquareIsLessThanTheNumber(double number1)
        {

            //Console.Write("Введите число:");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 2; i < number1; i++)
            {
                if (i * i < number1)
                {
                    result++;
                }
            }

            return result;
        }

        //                                                   задание 4

        public static double GreatestDivisor(double number1)
        {

            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            double result = 0d;

            for (double i = 2; i < number1; i++)
            {
                if (number1 % i == 0)
                {
                    result = i;
                }
            }
            return result;

        }

        //                                                   задание 5

        public static double SumOfNumbers(double number1, double number2)
        {

            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите ещё одно число:");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2)
            {
                double tmp = number1;
                number1 = number2;
                number2 = tmp;
            }

            int sum = 0;
            for (double i = number1; i <= number2; i++)
            {
                if (i % 7 == 0)
                {
                    sum += 1;
                }
            }
            return sum;
        }

    }
}

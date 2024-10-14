namespace domashka
{
    internal class While
    {

        //                                              четвёртое дз ⬇⬇⬇⬇

        //                                                  задание 1

        public static double GetNOD(double number1, double number2)
        {
            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите ещё одно число:");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 -= number2;
                }
                else
                {
                    number2 -= number1;
                }
            }

            return number1;
        }


        //                                                  задание 2
        public static double NumberOfOddDigits(double number1)
        {

            //    Console.WriteLine("Введите число:");
            //    double number1 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            while (number1 != 0)
            {
                if (number1! % 2 == 0)
                {
                    result += 1;
                }
                number1--;
            }
            return result;
        }

        //                                                 задание 3
        public static double NumberReversal(double number1)
        {

            //Console.WriteLine("Введите число:");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            while (number1 > 0)
            {
                double crnt = number1 % 10;
                number1 /= 10;

                result = result * 10 + crnt;
            }
            return result;
        }

    }
}


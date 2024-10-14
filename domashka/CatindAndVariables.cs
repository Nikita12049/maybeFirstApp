namespace domashka
{
    public static class CatindAndVariables
    //                                                    первое дз ⬇⬇⬇⬇

    //                                                       задание 1
    {
        public static int Delivery(int rate, int distanceFee, int distance)
        {
            int fee = rate + distanceFee * distance;
            return fee;
        }

        //                                                       задание 2

        public static double Bonus(double profitForTheMonth, double salesPlan)
        {
            double sum = profitForTheMonth - salesPlan;
            double bonus = sum * 0.1;
            return bonus;
        }

        //                                                       задание 3

        public static double Bank(double money, double inBank)
        {
            double sum = money + inBank;
            return sum;
        }

    }
}

using System;

namespace _01.SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerriesForKilo = decimal.Parse(Console.ReadLine());

            var portions = numberOfGuests / 6;
            if (numberOfGuests % 6 != 0)
            {
                portions++;
            }

            decimal totalMoney = portions * (2 * priceOfBananas) + portions * (4 * priceOfEggs) + portions * (0.2M * priceOfBerriesForKilo);

            if (totalMoney <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                decimal needMoney = totalMoney - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needMoney:F2}lv more.");
            }
        }
    }
}

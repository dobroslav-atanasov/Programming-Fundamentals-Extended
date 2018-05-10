namespace SweetDessert
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var priceOfBananas = decimal.Parse(Console.ReadLine());
            var priceOfEggs = decimal.Parse(Console.ReadLine());
            var priceOfBerriesForKilo = decimal.Parse(Console.ReadLine());

            var portions = numberOfGuests / 6;
            if (numberOfGuests % 6 != 0)
                portions++;

            var totalMoney = portions * 2 * priceOfBananas + portions * 4 * priceOfEggs +
                             portions * 0.2M * priceOfBerriesForKilo;

            if (totalMoney <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                var needMoney = totalMoney - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needMoney:F2}lv more.");
            }
        }
    }
}
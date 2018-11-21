using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PrizeWinningGame
{
    public enum Currency
    {
        Font,
        Dollar,
        Yuan,
        Forint,
        Pounds
    }



    class Participant
    {
        public struct Prize
        {
            public int Amount;
            public Currency currency;
        }
        private string name;
        private Prize prize;

        public Participant(string name)
        {
            this.name = name;
            GeneratePrize();
        }

        private void GeneratePrize()
        {
            Random randomAmount = new Random();
            
            prize.Amount = randomAmount.Next(1000, 10000);
            prize.currency = RandomCurrency();
            // var currencyList= new ArrayList(Currency)           
            Console.WriteLine($"Name :{name}  prize: {prize.Amount}  {prize.currency}");
        }

        private Currency RandomCurrency()
        {
            
            Random randomCurrency = new Random();
            var currencyType = Enum.GetValues(typeof(Currency));
            return (Currency)randomCurrency.Next(currencyType.Length);
        }

        public void ChangePrize()
        {
            prize.Amount /= 2;
            prize.currency = RandomCurrency();

           Console.WriteLine($"Now your Prize is {prize.Amount} {prize.currency}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public enum Currencies
    {
        Dollar,
        Yuan,
        Zebra,
        Pound,
    }

    public class BankAccount
    {
        
        
        public string Name { set; get; }
        public double Balance { set; get; }
        public Currencies Currency { set; get; }
        public string AnimalType { get; set; }
        public string IsGoodGuy { get; set; }
        public BankAccount(string name, double balance,Currencies currency, string animalType,string isGoodGuy)
        {
            Name = name;
            Balance = balance;
            Currency = currency;
            AnimalType = animalType;
            IsGoodGuy = isGoodGuy;
        }

        public BankAccount()
        {
        }
    }
}

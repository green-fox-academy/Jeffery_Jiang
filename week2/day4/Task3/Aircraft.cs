using System;
using System.Collections.Generic;
using System.Text;

namespace Aircraft
{
    class Aircraft
    {
        private string type;
        private int ammo;
        private int damage;
        private int Maxammo;
        private int basedamage;
        private int ammostore;

        public int Ammo { get => ammo; set => ammo = value; }
        public int Basedamages
        {
            get { return basedamage; }
            set { basedamage = value; }
        }
        

        public Aircraft()
        {
            //type = "default name";
            Ammo = 0;
            damage = 0;
        }

        public Aircraft(string type, int maxammo, int damage)
        {
            this.type = type;
            this.Maxammo = maxammo;
            this.basedamage = damage;
            ammostore = 0;
        }

        public int fight()
        {
            int alldamage=0;
            alldamage = Ammo * basedamage;
            Ammo = 0;
            return alldamage;

        }

        public int refill(int amount)
        {
            int currentammo = Ammo;
            if (Ammo + amount > Maxammo)
            {
                Ammo = Maxammo;
                return amount + currentammo - Maxammo;
            }
            else
            {
                Ammo = Ammo + amount;
                return Ammo-Maxammo;
            }
        }

        public string getType()
        {
            return type;
        }

        public void getStatus()
        {
            Console.WriteLine($"Type {type}, Ammo {Ammo}, Base Damage {basedamage},All Damage{Ammo*basedamage}");
        }

        public bool isPriority()
        {
            if (type == "F35")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}

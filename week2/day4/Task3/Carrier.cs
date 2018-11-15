using System;
using System.Collections.Generic;
using System.Text;

namespace Aircraft
{
    class Carrier
    {
        private List<Aircraft> aircraftlList;
        private int ammoStore;
        private int healthPoint;
        private int totalDamage;

        public Carrier(int ammoStore, int healthPoint)
        {
            this.ammoStore = ammoStore;
            this.healthPoint = healthPoint;
            aircraftlList=new List<Aircraft>();
        }

        public void add(Aircraft aircraft)
        {
            aircraftlList.Add(aircraft);
        }

        public void fill()
        {
            if (ammoStore == 0)
            {
                throw new Exception("No ammo remain!");
            }
            int totalammo=0;
            foreach (var aircraft in aircraftlList)
            {
                if (aircraft.getType() == "F16")
                {
                    totalammo += 8;
                }
                else if (aircraft.getType()=="F35")
                {
                    totalammo += 12;
                }
                
            }

            if (ammoStore < totalammo)
            {
                foreach (var aircraft in aircraftlList)
                {
                    if (ammoStore <= 0)
                    {
                        break;
                        
                    }
                    if (aircraft.isPriority())
                    {
                        ammoStore = aircraft.refill(ammoStore);

                    }
                }

                if (ammoStore > 0)
                {
                    foreach (var aircraft in aircraftlList)
                    {
                        if (ammoStore <= 0)
                        {
                            break;
                        }

                        if (!aircraft.isPriority())
                        {
                            ammoStore = aircraft.refill(ammoStore);
                        }
                    }
                }
            }
            else
            {
                foreach (var aircraft in aircraftlList)
                {
                    if (ammoStore <= 0)
                    {
                        break;
                        
                    }

                    ammoStore = aircraft.refill(ammoStore);
                }
            }
   
        }

        public void fight(Carrier anotherCarrier)
        {
            int output = 0;
            int input = 0;
            foreach (var aircraft in aircraftlList)
            {
                output += aircraft.fight();
            }

            
            foreach (var aircraft in anotherCarrier.aircraftlList)
            {
                input += aircraft.fight();
            }

            healthPoint -= input;
            anotherCarrier.healthPoint -= output;
        }

        public void getStatus()
        {
            if (healthPoint > 0)
            {
                foreach (var aircraft in aircraftlList)
                {
                    totalDamage += aircraft.Basedamages*aircraft.Ammo;
                }
                Console.WriteLine(
                    $"HP: {healthPoint}, Aircraft count {4}, Ammo Storage: {ammoStore}, Total damage: {totalDamage}");
                Console.WriteLine("Aircraft:");
                foreach (var aircraft in aircraftlList)
                {
                    aircraft.getStatus();
                }
            }
            else
            {
                Console.WriteLine("It's dead Jim");
            }
        }

    }
}

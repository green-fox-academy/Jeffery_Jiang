using System;
using System.Collections.Generic;
using System.Text;


namespace Reservations
{
    class Reservation:IReservationy
    {
        
        public string GetDOWBooking()
        {
            string[] weekStrings = {"MON", "TUE", "WEN", "THRU", "FIR", "SAT", "SUN"};

            Random random=new Random();
            int randomDayIndex = random.Next(0, 7);
            return weekStrings[randomDayIndex];
        }

        public string GetCodeBooking()
        {
            int randomNum;
            List<char> charList = new List<char>();
            string output;
            Random random = new Random();
            //randomNum = random.Next(48, 90);
            for (int i = 0; i < 8; i++)
            {
                randomNum = random.Next(48, 90);

                while (randomNum >= 58 && randomNum <= 64)
                {
                    randomNum = random.Next(48, 90);
                }
                
                charList.Add(Convert.ToChar(randomNum));
            }

            output = string.Join("", charList);
            return output;
        }
    }
}

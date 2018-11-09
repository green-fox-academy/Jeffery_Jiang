using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            int hours = 6;
            int days = 5;
            int weeks = 17;
            int averagehours = 52;
            int total = days * weeks * hours;
            double persentage= (double) averagehours/total;
            //int totalhours;


            Console.WriteLine("total hour {0}", total);

            Console.WriteLine("persentage {0}", persentage);
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
        }
    }
}
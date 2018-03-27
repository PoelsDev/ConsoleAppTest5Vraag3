using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest5Vraag3
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer = "2018-01-19";
            //string invoer = "Het is vandaag 19 januari.";

            bool succes;
            DateTime outputdatum = new DateTime();
            
            succes = DateTime.TryParse(invoer, out outputdatum);

            if (!succes)
            {
                Console.WriteLine("Er werd geen datum herkend.");
            }
            else
            {
                Console.WriteLine("Het is vandaag {0}.", outputdatum.DayOfWeek);
            }                                   
        }       
    }
}

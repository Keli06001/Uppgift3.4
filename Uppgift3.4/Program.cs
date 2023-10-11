using System;

namespace uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är låten? Skriv i heltal och avrunda ner");
            int minuter=int.Parse(Console.ReadLine());
            if (minuter >= 2 && minuter <= 4)
            {
                Console.WriteLine("Hur många sekunder avrundade du ner? Skriv i heltal");
                int sekunder = int.Parse(Console.ReadLine());
                if (minuter == 2 && sekunder>=45)
                {
                    Console.WriteLine("Din låt får spelas");
                }
                else if (minuter == 3 && sekunder >= 0)
                {
                    Console.WriteLine("Din låt får spelas");
                }
                else if (minuter == 4 && sekunder <= 20) 
                {
                    Console.WriteLine("Din låt får spelas");
                }
                else
                {
                    Console.WriteLine("Din låt får inte spelas");
                }
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas");
            }
            
        }
    }

}

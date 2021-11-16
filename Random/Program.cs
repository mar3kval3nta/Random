using System;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            int nahCislo = random.Next(1, 100);
            int tipCislo;
            bool neuhodl = true;
            Console.WriteLine("Hádání čísla");
            Console.WriteLine("-------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");

            while (neuhodl)
            {
                Console.Write("Tipni hodnotu");
                tipCislo = int.Parse(Console.ReadLine());
                if (tipCislo > nahCislo)
                {
                    Console.WriteLine("To je moc");
                }
                else if (tipCislo < nahCislo)
                {
                Console.WriteLine("To je málo");
                }
                else
                {
                    Console.WriteLine("Trefa");
                    neuhodl = false;
                }
            }
            Console.ReadLine();

            
            

            
            




        }
    }
}

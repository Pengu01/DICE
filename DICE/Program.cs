using System;

namespace DICE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            Console.WriteLine("How many dice will thou cast?"); 
            try 
            {
                int times = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("How many sides on them dice?"); 
                int highest = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Rolling..."); 
                for (int i = times; i > 0; i--) 
                {
                    Console.WriteLine(random.Next(1, highest + 1)); 
                }
            }
            catch(Exception) 
            {
                Console.WriteLine("ERROR 404"); 
            }
        }
    }
}

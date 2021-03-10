using System;


namespace Gambler
{
    class Program
    {
        public static int Start = 1;
        public static int End = 100;
        public static int bet = 1;
        public static int loss = 0;
        static void Main(string[] args)
       { 
        
        Random random = new Random();
        int Check = random.Next(0, 2);
            if (Check==bet)
            {
                Console.WriteLine("You are Won");
            }
            else
            {
                  Console.WriteLine("You are loss");
            }

           
        }
    }
}

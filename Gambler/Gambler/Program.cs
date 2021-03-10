using System;

namespace gambler
{
    class Program
    {
        //public static int End = 100;
        public static int Start = 1;


        static void Main(string[] args)
        {


            Condition();


        }
        public static void Condition()
        {
            int bet = 50;
            int stack = 100;
            //int Won = 100;
            int loss = 50;
            while (stack > loss && stack != loss)
            {
                Random random = new Random();
                int Check = random.Next(0, 2);
                if (Check == 1 && Start == 1)
                {
                    Console.WriteLine("you win");
                    stack=stack+bet;
                    Console.WriteLine("you left cost " + stack);
                }
                else
                {
                    Console.WriteLine("you lose");
                    stack=stack-bet;
                    Console.WriteLine("you left cost " + stack);
                }
                Console.ReadKey();
            }
        }
    }
}
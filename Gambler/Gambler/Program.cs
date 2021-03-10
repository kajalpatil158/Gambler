using System;

namespace gambler
{
    class Program
    {
        //public static int End = 100;
        public static int Start = 50;


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
            
            for (int i = 1; i <= 20; i++)

            {
                int Total = 0;
                int No_Won;
                int No_loss;
                while (stack > loss && stack != loss)
                {
                    Random random = new Random();
                    int Check = random.Next(0, 2);
                    
                    if (Check == 1 && Start == 50)
                    {
                        Console.WriteLine("you win");
                        stack = stack + bet;
                        //Total = stack + bet;
                        Total = Total + stack;
                        No_Won = i + 1;
                        Console.WriteLine("You Win Game with number of time is={0}", No_Won);
                        Console.WriteLine("Total is= {0}", Total);
                        i++;
                        Console.WriteLine("you Have cost " + stack);
                        


                    }
                    else
                    {
                        Console.WriteLine("you loss");

                        stack = stack - bet;
                        Total = stack - bet;
                        No_loss = i + 1;


                        //Console.WriteLine("You Loss Game with number of time is={0}", i);
                        //Console.WriteLine("this is {0} Time Total is= {0}", i, Total);
                        i++;
                        //Console.WriteLine("You Loss a stack with amount 50");
                        Console.WriteLine("you Have cost " + Total);
                        int Times = No_loss;
                        Console.WriteLine("You Loss Game with number of time is={0}", No_loss);
                    }
                    
                }
                Total = Total + stack;

                Console.WriteLine("Total is= {0}", Total);
                Console.ReadKey();
            }
            }
        
    }
}




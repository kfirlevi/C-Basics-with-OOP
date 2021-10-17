using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class RegisterManagement
    {
        public static void registerManagement()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 ~ Look at clients and products records");
                Console.WriteLine("2 ~ Look at workers shifts records");
                Console.WriteLine("3 ~ Check how long the registers' queues are");
                Console.WriteLine("4 ~ Go back to main menu");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Which register would you like to take a look at? (1/2/3)");
                    int X = int.Parse(Console.ReadLine());
                    RegistersQueue.ShowCostumerList(X);
                    RegistersQueue.ShowProductList(X);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Which register would you like to take a look at? (1/2/3)");
                    int X = int.Parse(Console.ReadLine());
                    RegistersQueue.WatchRecords(X);
                }
                else if (choice == 3)
                {
                    RegistersQueue.ShowQueuesLength();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incompatible answer. Please pick a number between 1 and 4");
                }
            }
        }
    }
}

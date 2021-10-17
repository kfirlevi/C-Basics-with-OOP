using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class QueueManagement
    {
        public static void queueManagement()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 ~ Add a costumer to the queue");
                Console.WriteLine("2 ~ Accepting a number of people into the grocery store");
                Console.WriteLine("3 ~ See who currently waits in the queue");
                Console.WriteLine("4 ~ Go back to main menu");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    EntranceQueue.newArrival();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("How many people would you like to accept into the store?");
                    int X = int.Parse(Console.ReadLine());
                    EntranceQueue.XPeopleLeaveQueue(X);
                }
                else if (choice == 3)
                {
                    EntranceQueue.WhosInQueue();
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

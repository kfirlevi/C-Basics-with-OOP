using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class WorkersManagement
    {
        public static void workersManagement()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 ~ Enter Work");
                Console.WriteLine("2 ~ Leave Work");
                Console.WriteLine("3 ~ Watch working record");
                Console.WriteLine("4 ~ Go back to main menu");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Please state your worker ID");
                    int workerID = int.Parse(Console.ReadLine());
                    //Console.WriteLine(workerID);
                    Console.WriteLine("Which register would you like to enter? (1/2/3)");
                    int registerID = int.Parse(Console.ReadLine());
                    Worker.StartWorking(workerID, registerID);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please state your worker ID");
                    int workerID = int.Parse(Console.ReadLine());
                    Worker.FinishWorking(workerID);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Please state your worker ID");
                    int workerID = int.Parse(Console.ReadLine());
                    Worker.WatchRecords(workerID);
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

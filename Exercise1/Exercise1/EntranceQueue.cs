using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class EntranceQueue
    {
        public static Queue entranceQueue = new Queue();
        public static void EnterQueue(Costumer costumer)
        {
            if (costumer.BodyHeat > 38)
            {
                Console.WriteLine("Body heat is higher than 38 degrees. Can't enter the queue!");
            }
            else if (!costumer.Mask || costumer.Isolation)
            {
                Console.WriteLine("Can't enter the queue!");
            }
            else
            {
                entranceQueue.Enqueue(costumer);
                Console.WriteLine("Queue length is " + entranceQueue.Count);
            }
        }
        
        public static void LeaveQueue()
        {
            if (entranceQueue.Count == 0)
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                //Costumer costumer = (Costumer)entranceQueue.Dequeue();
                Costumer costumer = (Costumer)entranceQueue.Dequeue();
                //Once the costumer enters the store, give him random products to simulate the shopping process (both type and amount are random)
                Random rnd = new Random();
                int productsNum = rnd.Next(1, 7);
                for (int i = 0; i < productsNum; i++)
                {
                    int rndID = rnd.Next(1, 7);
                    Costumer.AddProduct(costumer, rndID, false); // In case of repetitions, 'AddProduct' function will only add the first
                }
                RegistersQueue.EnterRegister(costumer);
            }
        }

        public static void WhosInQueue()
        {
            if (entranceQueue.Count == 0)
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Console.WriteLine("The costumers in the queue are:");
                foreach (Costumer costumer in entranceQueue)
                {
                    Console.WriteLine(costumer.CostumerID);
                }
            }

        }

        public static void XPeopleLeaveQueue(int X)
        {
            for (int i = 0; i < X; i++)
            {
                EntranceQueue.LeaveQueue();
                if (entranceQueue.Count == 0)
                {
                    Console.WriteLine("The queue is empty!");
                    break;
                }
            }
        }
        
        public static void newArrival()
        {
            Console.WriteLine("Enter costumer body heat: ");
            float bodyHeat = float.Parse(Console.ReadLine());
            Console.WriteLine("Does the costumer wear a mask? (y/n)");
            char mask_input = char.Parse(Console.ReadLine());
            bool mask;
            if (mask_input == 'y') mask = true; else mask = false; //in case of incompatible answer, take it as false for simplicity
            Console.WriteLine("Does the costumer need to be in isolation? (y/n)");
            char isolation_input = char.Parse(Console.ReadLine());
            bool isolation;
            if (isolation_input == 'n') isolation = false; else isolation = true; //in case of incompatible answer, take it as true for simplicity
            Costumer costumer1 = new Costumer(bodyHeat, mask, isolation);
            EntranceQueue.EnterQueue(costumer1);
            EntranceQueue.WhosInQueue();
        }
    
    
    }
}

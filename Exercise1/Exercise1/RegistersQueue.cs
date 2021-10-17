using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1
{
    class RegistersQueue
    {
        public static Register register1 = new Register();
        public static Register register2 = new Register();
        public static Register register3 = new Register();


        public static void AddCostumer(Register register, Costumer costumer)
        {
            if (register.CostumersList.Contains(costumer))
            {
                Console.WriteLine("The costumer is already in this register");
            }
            else
            {
                register.RegisterQueue.Enqueue(costumer);
                register.CostumersList.Add(costumer);
                register.CostumersList = register.CostumersList.OrderBy(costumer => costumer.CostumerID).ToList();
                register.ProductsList = register.ProductsList.Union(costumer.ProductsList).ToList();
                register.ProductsList = register.ProductsList.OrderBy(product => product.ProductID).ToList();
            }
        }

        public static void AddWorker(int registerID, Worker worker)
        {
            Register register = register1;
            if (registerID == 1)
            {

            }
            else if (registerID == 2)
            {
                register = register2;
            }
            else if (registerID == 3)
            {
                register = register3;
            }
            else
            {
                Console.Write("Invalid register number");
                return;
            }

            if (register.Occupied == false)
            {
                register.WorkerNum.Add(worker.WorkerID);
                register.StartHours.Add(worker.StartHours.Last());
                register.Occupied = true;
            }
            else
            {
                Console.WriteLine("This register is already occupied!");
            }
        }
        public static void RemoveWorker(int registerID, Worker worker)
        {
            Register register = register1;
            if (registerID == 1)
            {

            }
            else if (registerID == 2)
            {
                register = register2;
            }
            else if (registerID == 3)
            {
                register = register3;
            }
            else
            {
                Console.Write("Invalid register number");
                return;
            }

            if (register.Occupied == true)
            {
                register.FinishHours.Add(worker.FinishHours.Last());
                register.Occupied = false;
            }
            else
            {
                Console.WriteLine("This register isn't occupied!");
            }
        }

        public static void WatchRecords(int registerID)
        {
            Register register = register1;
            if (registerID == 1)
            {

            }
            else if (registerID == 2)
            {
                register = register2;
            }
            else if (registerID == 3)
            {
                register = register3;
            }
            else
            {
                Console.Write("Invalid register number");
                return;
            }

            for (int i = 0; i < register.WorkerNum.Count; i++)
            {
                Console.WriteLine("Worker {0}:", register.WorkerNum[i] + 1);
                Console.WriteLine("Started at {0}", register.StartHours[i]);
                if (i < register.FinishHours.Count)
                {
                    Console.WriteLine("Finished at {0}", register.FinishHours[i]);
                }
                else
                {
                    Console.WriteLine("Finish hour is not available yet");
                }
                Console.WriteLine("***");
            }
        }

        public static void EnterRegister(Costumer costumer)
        {
            int register1Length = register1.RegisterQueue.Count;
            int register2Length = register2.RegisterQueue.Count;
            int register3Length = register3.RegisterQueue.Count;
            if (register1Length <= register2Length && register1Length <= register3Length)
            {
                RegistersQueue.AddCostumer(register1, costumer);
            }
            else if (register2Length <= register1Length && register2Length <= register3Length)
            {
                RegistersQueue.AddCostumer(register2, costumer);
            }
            else
            {
                RegistersQueue.AddCostumer(register3, costumer);
            }
        }

        public static void ShowQueuesLength()
        {
            Console.WriteLine("The queue at register 1 has {0} costumers in it", register1.RegisterQueue.Count);
            Console.WriteLine("The queue at register 2 has {0} costumers in it", register2.RegisterQueue.Count);
            Console.WriteLine("The queue at register 3 has {0} costumers in it", register3.RegisterQueue.Count);
        }


        public static void ShowCostumerList(int registerID)
        {
            Register register = register1;
            if (registerID == 1)
            {
                
            }
            else if (registerID == 2)
            {
                register = register2;
            }
            else if (registerID == 3)
            {
                register = register3;
            }
            else
            {
                Console.Write("Invalid register number");
                return;
            }
            Console.Write("Register{0}'s costumers list is: ", register.RegisterID);
            foreach (Costumer costumer in register.CostumersList)
            {
                Console.Write(costumer.CostumerID + " ");
            }
            Console.WriteLine();
        }

        public static void ShowProductList(int RegisterID)
        {
            if (RegisterID == 1)
            {
                Console.Write("Register{0}'s products list is: ", register1.RegisterID);
                foreach (Product product in register1.ProductsList)
                {
                    Console.Write(product.ProductID + " ");
                }
            }
            else if (RegisterID == 2)
            {
                Console.Write("Register{0}'s products list is: ", register2.RegisterID);
                foreach (Product product in register2.ProductsList)
                {
                    Console.Write(product.ProductID + " ");
                }
            }
            else if (RegisterID == 3)
            {
                Console.Write("Register{0}'s products list is: ", register3.RegisterID);
                foreach (Product product in register3.ProductsList)
                {
                    Console.Write(product.ProductID + " ");
                }
            }
            else
            {
                Console.Write("Invalid register number");
            }
            Console.WriteLine();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Worker
    {
        public static Worker worker1 = new Worker();
        public static Worker worker2 = new Worker();
        public static Worker worker3 = new Worker();
        private int workerID;
        public int WorkerID 
        {
            get { return workerID; }
            set { workerID = value; }
        }
        private int currentRegister;
        public int CurrentRegister
        {
            get { return currentRegister; }
            set { currentRegister = value; }
        }
        public static int wID = 1;
        //static DateTime currentTime = DateTime.Now;
        //static string nowSTR = currentTime.ToString();
        private List<String> startHours = new List<string>();
        private List<String> finishHours = new List<string>();
        public List<String> StartHours 
        {
            get { return startHours; }
            set { startHours = value; }
        }
        public List<String> FinishHours
        {
            get { return finishHours; }
            set { finishHours = value; }
        }

        public static void StartWorking(int WorkerID, int registerID)
        {
            if (Worker.newArrival())
            {
                DateTime currentTime = DateTime.Now;
                string nowSTR = currentTime.ToString();
                Worker worker = worker1;
                if (WorkerID == 1) 
                {
                }
                else if (WorkerID == 2)
                {
                    worker = worker2;
                }
                else if (WorkerID == 3)
                {
                    worker = worker3;
                }
                else
                {
                    Console.WriteLine("We only employ 3 worker for now... Please try again!");
                    return;
                }
                if (worker.currentRegister != 0)
                {
                    Console.WriteLine("Already Working!");
                }
                else
                {
                    worker.StartHours.Add(nowSTR);
                    RegistersQueue.AddWorker(registerID, worker);
                    worker.CurrentRegister = registerID;
                }
            }
            else
            {
                Console.WriteLine("Can't enter the shop!");
                Console.WriteLine("You are fined 40 shekels for violating the rules!");
            }
        }

        public static void FinishWorking(int WorkerID)
        {
            DateTime currentTime = DateTime.Now;
            string nowSTR = currentTime.ToString();
            Worker worker = worker1;
            if (WorkerID == 1)
            {
            }
            else if (WorkerID == 2)
            {
                worker = worker2;
            }
            else if (WorkerID == 3)
            {
                worker = worker3;
            }
            else
            {
                Console.WriteLine("We only employ 3 worker for now... Please try again!");
                return;
            }
            if (worker.currentRegister == 0)
            {
                Console.WriteLine("Not Working!");
            }
            else
            {
                worker.FinishHours.Add(nowSTR);
                RegistersQueue.RemoveWorker(worker.currentRegister, worker);
                worker.currentRegister = 0;
            }
        }

        public static void WatchRecords(int WorkerID)
        {
            Worker worker = worker1;
            if (WorkerID == 1)
            {
            }
            else if (WorkerID == 2)
            {
                worker = worker2;
            }
            else if (WorkerID == 3)
            {
                worker = worker3;
            }
            else
            {
                Console.WriteLine("We only employ 3 worker for now... Please try again!");
                return;
            }

            for (int i = 0; i < worker.startHours.Count; i++)
            {
                Console.WriteLine("Started at {0}", worker.startHours[i]);
                if (i < worker.finishHours.Count)
                {
                    Console.WriteLine("Finished at {0}", worker.finishHours[i]);
                }
                else
                {
                    Console.WriteLine("Finish hour is not available yet");
                }
                Console.WriteLine("***");
            }
        }

        public static bool newArrival()
        {
            Console.WriteLine("Enter body heat: ");
            float bodyHeat = float.Parse(Console.ReadLine());
            Console.WriteLine("Do you wear a mask? (y/n)");
            char mask_input = char.Parse(Console.ReadLine());
            bool mask;
            if (mask_input == 'y') mask = true; else mask = false; //in case of incompatible answer, take it as false for simplicity
            Console.WriteLine("Do you need to be in isolation? (y/n)");
            char isolation_input = char.Parse(Console.ReadLine());
            bool isolation;
            if (isolation_input == 'n') isolation = false; else isolation = true; //in case of incompatible answer, take it as true for simplicity
            if (bodyHeat > 38 || !mask || isolation)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Worker()
        {
            this.WorkerID = wID++;
            this.CurrentRegister = 0;
        }
    }
}

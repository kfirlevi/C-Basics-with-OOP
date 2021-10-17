using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1
{
    class Register
    {
        private static int ID = 1;
        public int RegisterID { get; set; }

        private Queue<Costumer> registerQueue = new Queue<Costumer>();
        public Queue<Costumer> RegisterQueue
        {
            get { return registerQueue; } 
            set { registerQueue = value; }
        }

        private List<Costumer> costumersList = new List<Costumer>();
        public List<Costumer> CostumersList
        {
            get { return costumersList; }
            set { costumersList = value; }
        }

        private List<Product> productsList = new List<Product>();
        public List<Product> ProductsList
        {
            get { return productsList; }
            set { productsList = value; }
        }

        private List<int> workerNum = new List<int>();
        public List<int> WorkerNum
        {
            get { return workerNum; }
            set { workerNum = value; }
        }

        private List<String> startHours = new List<string>();
        public List<String> StartHours
        {
            get { return startHours; }
            set { startHours = value; }
        }

        private List<String> finishHours = new List<string>();
        public List<String> FinishHours
        {
            get { return finishHours; }
            set { finishHours = value; }
        }

        public bool Occupied { get; set; }

        public Register()
        {
            RegisterID = ID++;
            this.Occupied = false;
        }
    }
}

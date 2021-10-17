using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Person
    {
        private float bodyHeat;
        private bool mask;
        private bool isolation;

        public float BodyHeat 
        { 
            get
            {
                return bodyHeat;
            }
            set
            {
                bodyHeat = value;
            }
        }

        public bool Mask
        {
            get
            {
                return mask;
            }
            set
            {
                mask = value;
            }
        }

        public bool Isolation
        {
            get
            {
                return isolation;
            }
            set
            {
                isolation = value;
            }
        }

        public Person(float bodyHeat, bool mask, bool isolation)
        {
            this.bodyHeat = bodyHeat;
            this.mask = mask;
            this.isolation = isolation;

        }
    }

}

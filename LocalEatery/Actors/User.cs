using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors
{
    internal abstract class User
    {
        // Fields
        private string name "";
        private double wage = 0.0;
        private Day[] current_schedule; // I might need some clarification on this.

        public void setName(string newname)
        {
            this.name = newname;
        }

        public void setWage(double newWage)
        {
            this.wage = newWage;
        }

        public string getName()
        {
            return this.name;
        }

        public double getWage()
        {
            return this.wage;
        }

    }
}

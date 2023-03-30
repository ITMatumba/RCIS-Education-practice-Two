using System; 
using System.Collections.Generic;
using System.Text;

namespace _2._3
{
    class Worker
    {
        public string name = "";
        public string surname = "";
        public int rate;
        public int days;

        public int GetSalary()
        {
            return this.rate * this.days;
        }
    }
}

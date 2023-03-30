using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _2._2
{
    class counter
    {
        private int shetchick;
        public counter()
        {
            this.shetchick = 0;
        }
        public counter(int n)
        {
            this.shetchick = n;
        }
        public void shetchickOfLow()
        {
            this.shetchick--;
        }
        public void shetchickOfSum()
        {
            this.shetchick++;
        }
        public int Output
        {
            get { return shetchick; }
        }
    }
}


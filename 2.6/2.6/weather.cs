using System;         //2 класс
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _2._6
{
    class weather
    {
        public weatherCity Main { get; set; }
        public weatherCity[] Weather { get; set; }
        public string Name { get; set; }
    }
}
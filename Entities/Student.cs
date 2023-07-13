using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220713_000_lezione.Entities
{
    public class Student : IGrade
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }
}

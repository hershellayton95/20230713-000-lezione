using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230713_000_lezione.Servicies
{
    public interface ICalc
    {
        double CalcAverage(IEnumerable<double> doubles);
    }
}

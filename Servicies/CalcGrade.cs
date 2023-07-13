using _20220713_000_lezione.Entities;
using _20230713_000_lezione.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220713_000_lezione.Servicies
{
    public class CalcGrade
    {
        private readonly ICalc _calculator;

        public CalcGrade(ICalc calculator)
        {
            _calculator = calculator;
        }

        public double CalcDoubleAverage(IEnumerable<IGrade> collection)
        {
            if (collection.Count() <= 2) throw new Exception();
            return _calculator.CalcAverage(collection.Select(item => item.Grade))*2;
        }

        //public T GetBestStudent()
        //{
        //    return _listOfGrade.OrderByDescending(item => item.Grade).First();
        //}
    }
}

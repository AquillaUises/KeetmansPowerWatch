using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP_PowerWatch
{
    public class YearlyConsumption
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public float Units_Purchased { get; set; }

        public YearlyConsumption(int year, int month, float unitsPurchased)
        {
            Year = year;
            Month = month;
            Units_Purchased = unitsPurchased;
        }
    }
}

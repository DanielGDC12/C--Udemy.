using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise.Services
{
    class HourContract
    {

        public int hours { get; set; }
        public double valuePerHour { get; set; }
        public DateTime date { get; set; }


        public double totalValue()
        {
            return valuePerHour * hours;
        }
    }
}

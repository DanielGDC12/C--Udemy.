using System;

namespace EnumExercise.Services
{
    class HourContract
    {

        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public DateTime Date { get; set; }


        public HourContract() { }

        public HourContract(int hours, double valuePerHour, DateTime date)
        {
            Hours = hours;
            ValuePerHour = valuePerHour;
            Date = date;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}

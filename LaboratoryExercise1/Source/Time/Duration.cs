using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1
{
    public class Duration
    {
        public int Seconds { get; set; }
        
        public int Minutes { get; set; }

        public int Hours { get; set; }

        public Duration(int seconds, int minutes, int hours)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProject
{
    internal class Shedule
    {
        public void ShowShedule()
        {
            string[] Shedule = new string[]
            {
            "Monday - 10:00 - Math",
            "Tuesday - 9:00 - History",
            "Wednesday - 11:00 - Biology",
            "Thursday - 10:30 - Physics",
            "Friday - 9:00 - PE"
            };

            foreach (var i in Shedule)
            {
                Console.WriteLine(i);
            }
        }
    }
}

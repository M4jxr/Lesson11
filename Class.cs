using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProject
{
    internal class Classes
    {
        private string? NewStudents;
        public string NewStudent
        {
            get { return NewStudents; }
            set { NewStudents = value; }
        }
        public void Students()
        {
            string[] student = new string[]
            {
                "Maria",
                "Anna",
                "Anton"
            };

            foreach (var i in student)
            {
                Console.WriteLine(i);
            }
        }
    }
}

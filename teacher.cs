using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProject
{
    internal class Teacher
    {
        public void TeacherInfo()
        {
            string[] Teacher = { "Natalia  - Math", "Volodymyr - PE", "Tetiana - History" , "Stepan - Biology" , "Physics - Yevgen" };
            foreach (var i in Teacher)
            {
                Console.WriteLine(i);
            }
        }
    }
}

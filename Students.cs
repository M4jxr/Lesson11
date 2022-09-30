using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProject
{
    public class Students
    {
        string Name { get; set; }
        string Surname { get; set; }
        int age { get; set; }

        public Students(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            this.age = age;
        }

        public void Studentinfo()
        {
            Console.WriteLine(($"Student name: {Name}"));
            Console.WriteLine(($"Student surname: {Surname}"));
            Console.WriteLine(($"Student age: {age}"));

        }

    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalalarMaydoni
{
    public class Myclass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Initializer(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {Name} Yosh: {Age}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalalarMaydoni
{
    public class Student
    {
        public string Name { get; init; }
        public readonly int RegistrationNumber;

        public Student(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {Name} Ro'yxat raqami: {RegistrationNumber}");
        }
    }
}

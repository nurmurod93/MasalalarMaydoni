using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalalarMaydoni
{
    public class InitExample
    {
        private int _yearOfBirth;

        public  int YearOfBirth
        {
            get { return _yearOfBirth; }
            init { _yearOfBirth = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class factorial
    {
        public int Calculate(int number)
        {
            if(number ==1)
            {
                return 1;
            }

            return (number * Calculate(number - 1));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {
        // When using params we don't need to initialize the array. We can simply use
        // Calculator.Add(1, 2, 3) instead of Calculator.Add(new int[] {1, 2, 3})
        public int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class GenerateNumber
    {
        Random r = new Random();

        public int Generate()
        {
            return r.Next();
        }

        public double CalculateSD(int[] arr)
        {
            double tmp = arr.Average();
            double total = 0;
            for(int i=0;i<= arr.Length-1;i++)
            {
                total = +arr[i] - tmp;
            }
            return Math.Round(total / arr.Length);
        }
    }
}

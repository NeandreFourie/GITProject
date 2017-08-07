using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class GenerateClass
    {
        int n;
        int []randNum;
        int smallest;
        FormChris fc;

        public GenerateClass(int n, FormChris fc)
        {
            this.n = n;
            this.fc = fc;
            randNum = new int[n];
            generateNumbers();
            minNumber();
        }

        //Generate n random numbers and do a calculation with the numbers
        public void generateNumbers()
        {
            Random randomObj = new Random();

            for (int i = 0; i < n; i++)
            {
                randNum[i] = randomObj.Next(100);
            }
        }

        public void minNumber()
        {
            smallest = randNum[0];
            for(int i = 1; i < n; i++)
            {
                if(randNum[i] < smallest)
                {
                    smallest = randNum[i];
                }
            }

            fc.showStat(smallest);
        }
    }
}

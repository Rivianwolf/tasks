using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow_Without_POW
{
   
    
        public class MATH

        {
            public  double CustomPow(double baseNumber, double exponent, out Statuses status)
            {
                double result = 1;
                for (int i = 0; i < Math.Abs(exponent); i++)

                {

                    if (exponent >= 0)
                    {
                        result *= baseNumber;
                    }

                }
                if (exponent >= 0)
                {
                    status = Statuses.Success;
                }
                else
                {
                    status = Statuses.PowMustBePositiveOrZero;
                }
                return result;
            }


        public double Min(double Number1, double Number2, out Statuses status)
            {
            if (Number1 < Number2)
            {
                status = Statuses.Number1Min;
                return Number1;
            }
            else 
                {
                status = Statuses.Number2Min;
                return Number2;
                }
            }

        public double Max(double MaxNumber1, double MaxNumber2, out Statuses status)
        {
            if (MaxNumber1 > MaxNumber2)
            {
                status = Statuses.MaxNumber1;
                return MaxNumber1;
            }
            else
            {
                status = Statuses.MaxNumber2;
                return MaxNumber2;
            }
        }

    }
    

  
}

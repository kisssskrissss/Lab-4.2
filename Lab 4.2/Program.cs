using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPolozhit = 0;
            int sumOtric = 0;
            int i = Convert.ToInt32(Console.ReadLine());
            do
            {
                int i1 = Convert.ToInt32(Console.ReadLine());
                if (i1 > 0)
                    sumPolozhit++;
                if (i1 < 0)
                    sumOtric++;
                i = i1;
            }
            while ( i != 0);
            if (sumPolozhit > sumOtric)
                Console.WriteLine("больше положительных ");
            if (sumPolozhit < sumOtric)
                Console.WriteLine("больше отрицательных ");
            if (sumPolozhit == sumOtric)
                Console.WriteLine("одинаково ");
        }
    }
}

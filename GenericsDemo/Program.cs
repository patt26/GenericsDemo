using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            PrintArray<int> printinArray = new PrintArray<int>(inArray);
            printinArray.toPrint();
            
            PrintArray<double> printdoubleArray  = new PrintArray<double>(doubleArray);
            printdoubleArray.toPrint();
            
            PrintArray<char> printcharArray = new PrintArray<char>(charArray);
            printcharArray.toPrint();
            
        }
    }
}

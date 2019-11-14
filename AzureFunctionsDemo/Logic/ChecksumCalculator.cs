#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#endregion

[assembly:InternalsVisibleTo("AzureFunctionsDemoTests")]

namespace AzureFunctionsDemo.Logic
{
    internal class ChecksumCalculator
    {
        public int CalculateMultiplicationChecksum(int number)
            => IterateDigits(number, 1, (sum, digit) => sum * digit);

        public int CalculateAdditionChecksum(int number) 
            => IterateDigits(number, 0, (sum, digit) => sum + digit);

        private static int IterateDigits(int number, int result, Func<int, int, int> calculate)
        {
            (number, result) = IterateDigit(number, result, calculate);

            while (number > 0)
            {
                (number, result) = IterateDigit(number, result, calculate);
            }
            return result;
        }

        private static (int Number, int Result) IterateDigit(int number, int result, Func<int, int, int> calculate)
        {
            var digit = number % 10;
            result = calculate(result, digit);
            return (number / 10, result);
        }
    }
}

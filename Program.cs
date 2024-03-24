using System;

namespace c_sharp
{
    internal class Program
    {
        public static void Main()
        {
            int integerVariable = 10;
            string stringVariable = "Hello, World";
            double doubleVariable = 1.5;
            bool boolVariable = true;

            if (boolVariable)
            {
                doubleVariable *= integerVariable;
                stringVariable += " " + doubleVariable;
            }

            object[] mixedArray = new object[] { "one", 11, "two", 3.14, "END ARRAY:(" };

            foreach (var item in mixedArray)
            {
                Console.Write(item);
            }

            Console.WriteLine(stringVariable + ' ' + integerVariable * doubleVariable + boolVariable);
        }
    }
}
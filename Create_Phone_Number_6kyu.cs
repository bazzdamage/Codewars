using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Create_Phone_Number_6kyu //accepted
    {
        static int[] number = {1,2,3,4,5,6,7,8,9,0};
        public static void Main (String[] args)
        {
            Console.WriteLine(CreatePhoneNumber(number).ToString());
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder phonenumber = new StringBuilder();
            phonenumber.Append("(");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 2) phonenumber.Append(numbers[i]);
                else if (i == 2) phonenumber.Append(numbers[i] + ") ");
                else if (i >= 3 & i < 6) phonenumber.Append(numbers[i]);
                else if (i == 6) phonenumber.Append("-" + numbers[i]);
                else phonenumber.Append(numbers[i]);
            }
            return phonenumber.ToString();
        }
    }
}

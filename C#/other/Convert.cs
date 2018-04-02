using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace other
{
    public class Convert
    {
        public static string RomanNumeralFrom(int number)
        {
            return
                new string('I', number)
                    .Replace(new string('I', 1000), "M")
                    .Replace(new string('I', 900), "CM")
                    .Replace(new string('I', 500), "D")
                    .Replace(new string('I', 400), "CD")
                    .Replace(new string('I', 100), "C")
                    .Replace(new string('I', 90), "XC")
                    .Replace(new string('I', 50), "L")
                    .Replace(new string('I', 40), "XL")
                    .Replace(new string('I', 10), "X")
                    .Replace(new string('I', 9), "IX")
                    .Replace(new string('I', 5), "V")
                    .Replace(new string('I', 4), "IV");
        }

        public static string IntToRoman(int num)
        {
            string[] thou = { "", "M", "MM", "MMM" };
            string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string roman = "";
            roman += thou[(int)(num / 1000) % 10];
            roman += hun[(int)(num / 100) % 10];
            roman += ten[(int)(num / 10) % 10];
            roman += ones[num % 10];

            return roman;
        }

        public static string MethodConvert(int n)
        {

            string result = "";
            int thousands = n / 1000;
            int fiveHundred = (n % 1000) / 500;
            int hundred = (n % 500) / 100;
            int fifty = (n % 100) / 50;
            int ten = (n % 50) / 10;
            //int five = (n % 10) / 5;
            int one = (n % 10) / 1;

            for (int i = 0; i < thousands; i++)
            {
                result += "M";
            }
            for (int i = 0; i < fiveHundred; i++)
            {
                result += "D";
            }
            for (int i = 0; i < hundred; i++)
            {
                result += "C";
            }
            for (int i = 0; i < fifty; i++)
            {
                result += "L";
            }
            for (int i = 0; i < ten; i++)
            {

                if (i == 8)
                {

                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);

                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);

                    result = result.Remove(result.Length - 1);
                    //result = result.Remove(result.Length - 1);
                    // result += "XC";
                    result += "XC";

                }
                else if (i == 3)
                {
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    

                    result += "XL";
                }
                else
                {

                    result += "X";
                }
            }

            /*for (int i = 0; i < five; i++)
            {
                result += "V";
            }*/
            for (int i = 0; i < one; i++)
            {

                if (i == 8)        // else if NOT if
                {

                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);

                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);

                    //result = result.Remove(result.Length - 1);
                    result += "IX";
                }
                else if (i == 3)
                {
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);
                    result = result.Remove(result.Length - 1);

                    result += "IV";
                }
                else
                {

                    result += "I";
                }
                //result += "I";
            }

            if (one % 5 == 0)
            {
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result += "V";

            }

            return result;

        }
        class Program
        {
            static void Main(string[] args)
            {
                // OUTPUT = CCXCVI
                int line = 94;

                string res = IntToRoman(line);

                Console.WriteLine(res);
            }
        }
    }
}
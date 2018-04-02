
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace other
{
    public class Change
    {
        public static string MethodChange(string input)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            double[] array = Array.ConvertAll(input.Split(';'), Double.Parse);

            double change = array[1] - array[0];
            double cent = change * 100;
            string toReturn = "";
            if (array[1] < array[0])
            {
                toReturn = ("ERROR");
            }
            if (array[1] == array[0])
            {
                toReturn = ("ZERO");
            }

            if ((int)(cent / 10000) >= 1)
            {
                /*
                Everytime you find the a possible change, reduce your cents by the value.
                 */
                myDict.Add("ONE HUNDRED", (int)(cent / 10000));
                cent = cent - 10000 * (int)(cent / 10000);
            }

            if ((int)((cent % 10000) / 5000) >= 1)
            {
                myDict.Add("FIFTY", (int)((cent % 10000) / 5000));

                cent = cent - 5000 * (int)((cent % 10000) / 5000);
            }
            myDict.Add("TWENTY", (int)((cent % 5000) / 2000));
            myDict.Add("TEN", (int)((cent % 2000) / 1000));

            if ((int)((cent % 1000) / 500) >= 1)
            {
                myDict.Add("FIVE", (int)((cent % 1000) / 500));

                cent = cent - 500 * (int)((cent % 1000) / 500);
            }
            myDict.Add("TWO", (int)((cent % 500) / 200));
            myDict.Add("ONE", (int)((cent % 200) / 100));
            myDict.Add("HALF DOLLAR", (int)((cent % 100) / 50));
            myDict.Add("QUARTER", (int)((cent % 50) / 25));
            myDict.Add("DIME", (int)((cent % 25) / 10));
            myDict.Add("NICKEL", (int)((cent % 10) / 5));
            myDict.Add("PENNY", (int)((cent % 5) / 1));

            for (int i = 0; i < myDict.Count; i++)
            {
                var item = myDict.ElementAt(i);
                if (item.Value > 0)
                {
                    toReturn += string.Format("{0},", item.Key);

                }
                if (i == myDict.Count - 1)
                {
                    toReturn = toReturn.Remove(toReturn.Length - 1);

                }
            }

            return toReturn;

        }
        static void Main()
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    try
                    {

                        string res = MethodChange(line);
                        Console.WriteLine(res);
                    }
                    catch (System.Exception)
                    {

                        throw;
                    }

                }
        }
    }
}
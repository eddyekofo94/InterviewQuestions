using System;
using System.Collections.Generic;
using System.Linq;

namespace other
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            string key;
            string val;

            string userInput = "tip,955; crk,123; dub,548;";

            string[] wordbits = userInput.Split(new char[] { ',', ';' });

            // userInput.Count\
            for (int i = 0; i < wordbits.Length - 1; i += 2)
            {
                key = wordbits[i];
                val = wordbits[(i + 1)];

                myDict.Add(key, Convert.ToInt32(val));
            }

            int result = 0;

            myDict = myDict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            for (int i = 0; i <  myDict.Count; i++)
            {
                var item = myDict.ElementAt(i);

                result = item.Value - result;
                Console.WriteLine(result);
            }
        }
    }
}


using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public static class Program
{

    //3900
    public static string MethodConvert(int n)
    {

        string result = "";
        int thousands = n / 1000;
        int fiveHundred = (n % 1000) / 500;
        int hundred = (n % 500) / 100;
        int fifty = (n % 100) / 50;
        int ten = (n % 50) / 10;
        int five = (n % 10) / 5;
        int one = (n % 5) / 1;

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
            if (i >= 3)
            {
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result += "XC";
            }
            if (i >= 8)
            {

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result += "XC";
            }
            else
            {

                result += "X";
            }
        }

        for (int i = 0; i < five; i++)
        {
            result += "V";
        }
        for (int i = 0; i < one; i++)
        {
            if (i >= 3)
            {
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result += "IV";
            }
            if (i >= 8)
            {

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);

                result = result.Remove(result.Length - 1);
                result = result.Remove(result.Length - 1);
                result += "IX";
            }
            else
            {

                result += "I";
            }
            //result += "I";
        }

        return result;

    }

    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string res = MethodConvert(Convert.ToInt32(line));

                Console.WriteLine(res);
            }
    }
}



using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public static class Program
{
    public static string MethodChange(string input)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        //input.Split(";");
        double[] array = Array.ConvertAll(input.Split(';'), Double.Parse);
        //myDict.Add(array[0], array[1]);

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


        myDict.Add("ONE HUNDRED", (int)(cent / 10000));

        myDict.Add("FIFTY", (int)((cent % 10000) / 5000));
        myDict.Add("TWENTY", (int)((cent % 5000) / 2000));
        myDict.Add("TEN", (int)((cent % 2000) / 1000));
        myDict.Add("FIVE", (int)((cent % 1000) / 500));
        myDict.Add("TWO", (int)((cent % 500) / 200));
        myDict.Add("ONE", (int)((cent % 200) / 100));
        myDict.Add("HALF DOLLAR", (int)((cent % 100) / 50));
        myDict.Add("QUARTER", (int)((cent % 50) / 25));
        myDict.Add("DIME", (int)((cent % 25) / 10));
        myDict.Add("NICKEL", (int)((cent % 10) / 5));
        myDict.Add("PENNY", (int)((cent % 5) / 1));

        foreach (var item in myDict)
        {
            if (item.Value > 0)
            {
                toReturn += string.Format("{0},", item.Key);
            }
            //item.Value
        }


        return toReturn;



    }
    static void Main()
    {

        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string res = MethodChange(line);

                Console.WriteLine(res);
            }
    }
}
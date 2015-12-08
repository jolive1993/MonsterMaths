using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMaths
{
    public static class Math
    {
        public static List<int> happyFinder(int num)
        {
            List<int> happyList = new List<int>();
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum = i;
                for (int y = 0; y < 10000; y++)
                {
                    if (sum != 1)
                    {
                        sum = happyFinderLoop(sum);
                    }
                    else
                    {
                        happyList.Add(i);
                        break;
                    }
                }
            }
            return happyList;
        }
        private static int happyFinderLoop(int num)
        {
            string numberString;
            List<char> charList = new List<char>();
            List<int> convertedNumberList = new List<int>();
            int convertedNumber;
            string convertedString;
            int convertedNumberSum = 0;
            numberString = num.ToString();
            charList = numberString.ToList();
            foreach (char c in charList)
            {
                convertedString = c.ToString();
                convertedNumber = Int32.Parse(convertedString);
                convertedNumber = convertedNumber * convertedNumber;
                convertedNumberList.Add(convertedNumber);
            }
            foreach (int y in convertedNumberList)
            {
                convertedNumberSum += y;
            }
            return convertedNumberSum;
        }
        public static void romanConverter(ref string input)
        {
            int num;
            num = Int32.Parse(input);
            input = null;
            while (num > 0)
            {
                if (num >= 1000)
                {
                    num -= 1000;
                    input += "M";
                }
                else if (num >= 900 && num < 1000)
                {
                    num -= 900;
                    input += "CM";
                }
                else if (num >= 500 && num < 900)
                {
                    num -= 500;
                    input += "D";
                }
                else if (num >= 400 && num < 500)
                {
                    num -= 400;
                    input += "CD";
                }
                else if (num >= 100 && num < 400)
                {
                    num -= 100;
                    input += "C";
                }
                else if (num >= 90 && num < 100)
                {
                    num -= 90;
                    input += "XC";
                }
                else if (num >= 50 && num < 90)
                {
                    num -= 50;
                    input += "L";
                }
                else if (num >= 40 && num < 50)
                {
                    num -= 40;
                    input += "XL";
                }
                else if (num >= 10 && num < 40)
                {
                    num -= 10;
                    input += "X";
                }
                else if (num == 9)
                {
                    num -= 9;
                    input += "IX";
                }
                else if (num >= 5 && num < 10)
                {
                    num -= 5;
                    input += "V";
                }
                else if (num == 4)
                {
                    num -= 4;
                    input += "IV";
                }
                else if (num >= 1 && num < 5)
                {
                    num -= 1;
                    input += "I";
                }
            }
        }
        public static int euclidean(int num1, int num2)
        {
            int gcd = -1;
            while (gcd != 0)
            {
                num1 = gcd = num1 % num2;
                if (gcd == 0)
                {
                    return num2;
                }
                num2 = gcd = num2 % num1;
            }
            return num1;
        }
        public static int outlierFinder(List<int> data)
        {
            List<int> q1List = new List<int>();
            List<int> q3List = new List<int>();
            int median;
            int med1;
            int med2;
            int Q1;
            int Q2;
            int Q3;
            int IQR; 
            
            data.Sort();
            if (data.Count() % 2 != 0)
            {
                median = (data.Count / 2);
                Q2 = data[median];
                data.RemoveAt(median);

            }
            else
            {
                med1 = (data.Count() / 2) - 1;
                med2 = (data.Count() / 2);
                Q2 = (data[med1] + data[med2]) / 2;

            }
            for (int i = 0; i < (data.Count() / 2); i++)
            {
                q1List.Add(data[i]);
            }
            for (int y = (q1List.Count); y < data.Count(); y++)
            {
                q3List.Add(data[y]);
            }
            Q1 = medianFinder(q1List);
            Q3 = medianFinder(q3List);
            IQR = Q3 - Q1;
            return IQR;


        }
        private static int medianFinder(List<int> data)
        {
            int median;
            int medianRound;
            int result;
            int med1;
            int med2;
            data.Sort();
            if (data.Count() % 2 != 0)
            {
                median = (data.Count() / 2);
                result = data[median];
                return result;
            }
            else
            {
                med1 = (data.Count() / 2) - 1;
                med2 = (data.Count() / 2);
                median = (data[med1] + data[med2]) / 2;
                return median;
            }
        }
    }
}
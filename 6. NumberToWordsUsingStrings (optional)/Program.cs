using System;

namespace NumberToWordsUsingStrings
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int addCommas(ref string numberStr)
        {
            int counter = 0, numberOfCommas = 0;
            numberStr = ReverseString(numberStr);
            for (int i = 0; i < numberStr.Length; i++)
            {
                counter++;
                if (counter == 4)
                {
                    numberStr = numberStr.Insert(i, ",");
                    numberOfCommas++;
                    counter = 0;
                }
            }
            numberStr = ReverseString(numberStr);
            return numberOfCommas;
        }

        static int numberOfDigits(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                counter++;
                number = number / 10;
            }
            return counter;
        }

        static string numberToWords(int number)
        {
            string words = "";
            switch (number)
            {
                case 0: words = "Zero"; break;
                case 1: words = "One"; break;
                case 2: words = "Two"; break;
                case 3: words = "Three"; break;
                case 4: words = "Four"; break;
                case 5: words = "Five"; break;
                case 6: words = "Six"; break;
                case 7: words = "Seven"; break;
                case 8: words = "Eight"; break;
                case 9: words = "Nine"; break;
                case 10: words = "Ten"; break;
                case 11: words = "Eleven"; break;
                case 12: words = "Twelve"; break;
                case 13: words = "Thirteen"; break;
                case 14: words = "Fourteen"; break;
                case 15: words = "Fifteen"; break;
                case 16: words = "Sixteen"; break;
                case 17: words = "Seventeen"; break;
                case 18: words = "Eighteen"; break;
                case 19: words = "Nineteen"; break;
                case 20: words = "Twenty"; break;
                case 30: words = "Thirty"; break;
                case 40: words = "Forty"; break;
                case 50: words = "Fifty"; break;
                case 60: words = "Sixty"; break;
                case 70: words = "Seventy"; break;
                case 80: words = "Eighty"; break;
                case 90: words = "Ninety"; break;
                case 100: words = "Hundred"; break; //number > 100
            }
            return words;
        }

        static string getPrefix(int currentCommaCount) {
            string prefix = "";
            switch (currentCommaCount)
            {
                case 1: prefix = "Thousand"; break;
                case 2: prefix = "Million"; break;
                case 3: prefix = "Billion"; break;
            }
            return prefix;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in digits: ");
            string numberStr = Console.ReadLine();
            int numberOfCommas = addCommas(ref numberStr);
            Console.WriteLine(numberStr + "\nNumber of Commas: " + numberOfCommas);
            //201,111,201
            string[] numbersToWord = numberStr.Split(",");
            // [0] = 201, [1] = 111, [2] = 201
            for(int i = 0; i < numbersToWord.Length; i++)
            {
                int number = int.Parse(numbersToWord[i]);
                //number = 201
                Console.Write(numberToWords(int.Parse(numbersToWord[i].Substring(0, 1))));
                //prints 'Two'
                Console.Write(" Hundred ");
                int lastTwoDigits = int.Parse(numbersToWord[i].Substring(1, 2));
                //lastTwoDigits = 01
                if (lastTwoDigits > 19) //which is false in this case
                {
                    Console.Write(numberToWords(lastTwoDigits / 10 * 10)); //prints twenty, thirty etc.
                    Console.Write(" " + numberToWords(lastTwoDigits % 10)); //prints one, two etc. (" " is just for formatting)
                }
                else
                {
                    //will print 'One'
                    Console.Write(numberToWords(lastTwoDigits));
                }
                Console.Write(" " + getPrefix(numberOfCommas) + ", "); //will print Billion/Million/Thousand
                numberOfCommas--;
            }
            Console.Write("\b\b."); //to remove the extra ", " and add "."
        }
    }
}

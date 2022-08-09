using System;

namespace Lab3_problem_007
{
    class Program
    {
        //задача про додавання римських чисел
        static int[] romanRangs = new int[7] { 1000, 500, 100, 50, 10, 5, 1 };
        static string[] romanDigits = new string[7] { "M", "D", "C", "L", "X", "V", "I" };
        static char separator = '+';

        static void Main(string[] args)
        {
            int sumResult = 0;

            string inputData = Console.ReadLine();

            string[] separatedInput = Separate(inputData);
            if(separatedInput.Length != 2)
            {
                Console.WriteLine("Invalid Input data!");
                return;
            }

            foreach (string str in separatedInput)
            {
                int[] currentNumber = ParseNumber(str);
                sumResult += CalcSum(currentNumber);
            }
            
            Console.WriteLine($"{ConvertToRoman(sumResult)}");

            Console.ReadKey();
        }

        static int RomanToDigit(string value)
        {
            return value switch
            {
                "I" => 1,
                "V" => 5,
                "X" => 10,
                "L" => 50,
                "C" => 100,
                "D" => 500,
                "M" = > 1000,
                _ => throw new ArgumentException("incorrect roman letter")
            };
            //return 1;
            
            
            /*switch (value)
            {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
                default:
                    return 0;
            }*/
        }

        static int CalcSum(int[] currentNumber)
        {
            int result = 0;
            int[] currentNumberSigned = new int[currentNumber.Length];

            for (int i = 0; i < currentNumber.Length; i++)
            {
                currentNumberSigned[i] = currentNumber[i];

                if (i + 1 < currentNumber.Length && currentNumber[i] < currentNumber[i + 1])
                {
                    currentNumberSigned[i] = currentNumber[i] * (-1);
                }
            }

            for (int i = 0; i < currentNumber.Length; i++)
            {
                result += currentNumberSigned[i];
            }

            return result;
        }

        private static int[] ParseNumber(string str)
        {
            int[] currentNumber = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                currentNumber[i] = RomanToDigit(str[i].ToString());
            }

            return currentNumber;
        }

        static string[] Separate(string inputData)
        {
            string[] separatedInput = inputData.Split(separator);
            return separatedInput;
        }

        static string ConvertToRoman(int sumResult)
        {
            if (!(sumResult <= 4000))
            {
                return null;
            }

            int arabResult = sumResult;
            int number = arabResult;

            int index = 0;
            int remainder = 0;
            string sumResultRoman = default;

            do
            {
                remainder = arabResult / romanRangs[index];
                number = arabResult - remainder * romanRangs[index];

                if (arabResult == 9)
                {
                    sumResultRoman += (romanDigits[6] + romanDigits[4]);
                    break;
                }

                if (remainder == 9)
                {
                    sumResultRoman += (romanDigits[index + 2] + romanDigits[index]);
                    arabResult = number;
                }

                if (remainder <= 3)
                {
                    for (int i = 0; i < remainder; i++)
                    {
                        sumResultRoman += romanDigits[index];
                        arabResult = number;
                    }
                }
                if (remainder == 4)
                {
                    sumResultRoman += (romanDigits[index] + romanDigits[index - 1]);
                    arabResult = number;
                }
                index++;

            }
            while (arabResult > 0);

            return sumResultRoman;
        }

    }
}

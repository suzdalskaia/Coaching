using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_problem_007
{
    class Program
    {
        //задача про додавання римських чисел
        
        static void Main(string[] args)
        {
            int sumResult = 0;
            
            string inputData = "III+IV";

            char separator = '+';

            string[] separatedInput = inputData.Split(separator);

            foreach(string str in separatedInput)
            {
                int[] currentNumber = new int[str.Length];
                int[] currentNumberSigned = new int[currentNumber.Length];

                for(int i = 0; i < str.Length; i++)
                {
                    int correspondingDigit;
                    switch (str[i])
                    {
                        case 'I':
                            correspondingDigit = 1;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'V':
                            correspondingDigit = 5;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'X':
                            correspondingDigit = 10;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'L':
                            correspondingDigit = 50;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'C':
                            correspondingDigit = 100;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'D':
                            correspondingDigit = 500;
                            currentNumber[i] = correspondingDigit;
                            break;
                        case 'M':
                            correspondingDigit = 1000;
                            currentNumber[i] = correspondingDigit;
                            break;
                    }
                    
                }

                for(int i = 0; i < currentNumber.Length; i++)
                {
                    currentNumberSigned[i] = currentNumber[i];

                    if ( i + 1 < currentNumber.Length && currentNumber[i] < currentNumber[i + 1])
                    {
                        currentNumberSigned[i] = currentNumber[i] * (-1);
                    }
                }

                for(int i = 0; i < currentNumber.Length; i++)
                {
                    sumResult += currentNumberSigned[i];
                }
            }

            Console.WriteLine($"{sumResult}");           

            if (!(sumResult <= 4000))
            {
                return;
            }

            int[] romanRangs = new int[7] { 1000, 500, 100, 50, 10, 5, 1 };
            string[] romanDigits = new string[7] { "M", "D", "C", "L", "X", "V", "I" };

            int arabResult = sumResult;
            int number = arabResult;

            int index = 0;
            int remainder = 0;
            string sumResultRoman = default;

            do
            {
                remainder = arabResult / romanRangs[index];
                number = arabResult - remainder * romanRangs[index];

                if(arabResult == 9)
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
            
            Console.WriteLine($"{sumResultRoman}");

            Console.ReadKey();

        }
    }
}

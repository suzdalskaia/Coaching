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
            
            string inputData = "III+LXXIV";

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

            Console.ReadKey();

        }
    }
}

using System;

namespace LettersToNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a message");
            string input = Console.ReadLine();
            string output = null;

            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int index = char.ToUpper(input[i]) - 64;
                    if (!(index >= 1 && index <= 26))
                    {
                        continue;
                    }
                    output += $"{index} ";
                }
            }

            if (output != null)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Please enter your message in english only");
            }

        }
    }
}
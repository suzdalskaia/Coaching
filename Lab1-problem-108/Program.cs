using System;

namespace Lab1_problem_108
{
    class Program
    {
        //задача вивести середнє число з 3х цілих, які по модулю менше ніж 1000

        static void Main(string[] args)
        {
            int a = 11;
            int b = 3;
            int c = 7;

            int medium;

            if(a >=-1000 && a <= 1000 && b >= -1000 && b <= 1000 && c >= -1000 && c <= 1000)
            {
                if (a < b)
                {
                    if (b < c)
                    {
                        medium = b;
                    }
                    else
                    {
                        if (a < c)
                        {
                            medium = c;
                        }
                        else
                        {
                            medium = a;
                        }
                    }
                }
                else
                {
                    if (c < b)
                    {
                        medium = b;
                    }
                    else
                    {
                        if (c < a)
                        {
                            medium = c;
                        }
                        else
                        {
                            medium = a;
                        }
                    }
                }

                Console.WriteLine(medium);
                Console.ReadKey();
            }
        }
    }
}

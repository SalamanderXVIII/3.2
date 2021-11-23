using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.2, 2-й вариант, высокий уровень, Гребенюк
            try
            {
                int x = 0, y = 0;
                for (int i = 200; i <= 300; i++)
                {
                    x = 0;
                    y = 0;
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                            x += j;
                    }
                    if (x >= 200 || x <= 300)
                        for (int h = 1; h <= x / 2; h++)
                        {
                            if (x % h == 0)
                                y += h;
                        }
                    if (y == i)
                        Console.WriteLine(i + " и " + x);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

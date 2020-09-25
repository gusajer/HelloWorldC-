using System;
namespace HelloWorld
{
    class Program
    {
        // gustav
        static int[] tal = new int[] { 11, 100, 66, 90, 80, 88, 120, 12 };
        static int[] tal5 = new int[] { 66, 112, 66, 99, 80, 6564, 4444, 444454 };
        static void Main(string[] args)
        {
            //gustav
            Console.WriteLine("[{0}]", string.Join(", ", tal));
            OddEven lala = new OddEven();
            lala.Even(tal);
            Chilas(tal);
            Matias(tal);
            Console.WriteLine("[{0}]", string.Join(", ", tal5));
            lala.Even(tal5);
            Chilas(tal5);
            Matias(tal5);
            int[] tal2 = RandomNumbers();
            Chilas(tal2);
            Matias(tal2);
        }
        // chilas-
        public static void Matias(int[] array)
        {
            int odd5 = 0;
            int even5 = 0;
            int temp5 = 0;
            int temp15 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even5++;
                    if (even5 == 1)
                    {
                        temp5 = i;
                    }
                }
                else
                {
                    odd5++;
                    if (odd5 == 1)
                    {
                        temp15 = i;
                    }
                }
            }
            if (odd5 == 1) { Console.WriteLine(array[temp15]); }
            else if (even5 == 1) { Console.WriteLine(array[temp5]); }
            else { Console.WriteLine("fail"); }
        }
        public static void Chilas(int[] array)
        {
            int even = 0;
            int odd = 0;
            int temp = 0;
            int temp2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                    temp = array[i];
                }
                else
                {
                    odd++;
                    temp2 = array[i];
                }
            }
            if (odd == 1)
            {
                temp = temp2;
            }
            Console.WriteLine(temp);
        }
        public static int[] RandomNumbers()
        {
            Random random = new Random();
            int oddoreven = random.Next(0, 2);
            int arraynumber = random.Next(3, 10);
            int exception = random.Next(0, arraynumber);
            int[] array = new int[arraynumber];
            for (int i = 0; i < array.Length; i++)
            {
                int number = random.Next(1, 100);
                if (oddoreven == 0)
                {
                    if (i == exception)
                    {
                        if (number % 2 == 0)
                        {
                            array[i] = number - 1;
                        }
                        else
                        {
                            array[i] = number;
                        }
                    }

                    else if (number % 2 == 0)
                    {
                        array[i] = number;
                    }
                    else
                    {
                        array[i] = number + 1;
                    }
                }
                else if (oddoreven == 1)
                {
                    if (i == exception)
                    {
                        if (number % 2 != 0)
                        {
                            array[i] = number - 1;
                        }
                        else
                        {
                            array[i] = number;
                        }
                    }
                    else if (number % 2 != 0)
                    {
                        array[i] = number;
                    }
                    else
                    {
                        array[i] = number + 1;
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
            return array;
        }
    }
}
// gustav
class OddEven
{
    public void Even(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.Write(array[i] + "\n");

            }

        }

    }
}
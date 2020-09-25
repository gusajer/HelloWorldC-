using System;

namespace HelloWorld
{
    class Program
    {
        // gustav
        static int[] tal = new int[] { 11, 100, 66, 90, 80, 88, 120, 12 };
        // matias
        static int[] tal2 = new int[5] { 2, 4, 6, 8, 9 };
        static int[] tal3 = new int[5] { 2, 4, 21, 8, 10 };
        static int[] tal4 = new int[5] { 23, 2, 244, 50, 10 };
        static void Main(string[] args)
        {
            // gustav
            OddEven lala = new OddEven();
            //lala.Even(tal);
            //chilas
            // Matias(tal);
            // matias
            Console.WriteLine("Hello World!" + "\n");
            Gustav matias = new Gustav();
            //matias.Chilas(tal2);
            //matias.Chilas(tal3);
            //matias.Chilas(tal4);
            matias.Chilas(matias.RandomNumbers());

        }
        // chilas
        public static void Matias(int[] array)
        {
            int odd = 0;
            int even = 0;
            int temp = 0;
            int temp1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                    if (even == 1)
                    {
                        temp = i;
                    }
                }
                else
                {
                    odd++;
                    if (odd == 1)
                    {
                        temp1 = i;
                    }
                }
            }
            if (odd == 1) { Console.WriteLine(array[temp1]); }
            else if (even == 1) { Console.WriteLine(array[temp]); }
            else { Console.WriteLine("fail"); }
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
// matias
class Gustav
{
    public void Chilas(int[] array)
    {
        int even = 0;
        int odd = 0;
        int temp = 0;
        int temp2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                temp = array[i];
                even++;
            }
            if (array[i] % 2 > 0)
            {
                temp2 = array[i];
                odd++;
            }
        }
        if (even >= 1)
        {
            temp = temp2;
        }
        else if (odd >= 1)
        {
            temp = temp2;
        }
        //Console.WriteLine(temp);
    }

    public int[] RandomNumbers()
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


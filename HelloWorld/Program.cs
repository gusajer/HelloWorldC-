using System;

namespace HelloWorld
{
    class Program
    {
        static int[] tal = new int[] { 11, 100, 66, 90, 80, 88, 120, 12 };
        static void Main(string[] args)
        {
            OddEven lala = new OddEven();
            lala.Even(tal);
            Matias(tal);
 
        }

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

class OddEven
{
    public void Even(int[] array)
    {

        for (int i = 0; i < array.Length ; i++)
        {
            if (array[i] % 2 != 0)
            {
                    Console.Write(array[i] + "\n");

            }

        }
       
    }
}


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
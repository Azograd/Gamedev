using System;

class Program
{
    static void Main()
    {
        double[] array1 = new double[21];
        double[] array2 = new double[21];
        double[] resultArray = new double[21];

        for (int i = 0; i < 21; i++)
        {
            array1[i] = i + 1;
            array2[i] = (i + 1) * 2;
        }

        for (int i = 0; i < 21; i++)
        {
            if (i < 11)
            {
                resultArray[i] = array1[i] * array2[10 - i];
            }
            else
            {
                resultArray[i] = array1[i] * array2[i];
            }
        }

        resultArray[10] = Math.Sqrt(resultArray[10]);

        Console.WriteLine("Массив 1:");
        for (int i = 0; i < 21; i++)
        {
            Console.WriteLine("array1[" + i + "] = " + array1[i]);
        }

        Console.WriteLine("Массив 2:");
        for (int i = 0; i < 21; i++)
        {
            Console.WriteLine("array2[" + i + "] = " + array2[i]);
        }

        Console.WriteLine("Результирующий массив:");
        for (int i = 0; i < 21; i++)
        {
            Console.WriteLine("resultArray[" + i + "] = " + resultArray[i]);
        }
    }
}

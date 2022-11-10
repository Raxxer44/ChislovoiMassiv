using System;
class SergArray
{
    static void Main(string[] args)
    {
        int[] myArray = new int[10];
        Random rand = new Random();

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = rand.Next(33);
        }
        Console.WriteLine("myArray: ");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("Значение элемента массива (индекс " + i + ") = " + myArray[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 3 == 0)
            {
                Console.WriteLine("Значение элемента массива делённого на 3 (индекс " + i + ") = " + myArray[i]);
            }
        }
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 5 == 0)
            {
                Console.WriteLine("Значение элемента массива делённого на 5 (индекс " + i + ") = " + myArray[i]);
            }
        }
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            if ((myArray[i] % 3 == 0) && (myArray[i] % 5 == 0))
            {
                Console.WriteLine("Значение элемента массива делённого на 3 и 5 (индекс " + i + ") = " + myArray[i]);
            }
        }

        Console.ReadKey();
    }
}
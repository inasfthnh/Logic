using System;
namespace Base
{
    public class LogicFunction
    {
        public static void PrintArray(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + "\t"); //tab
                    //perpindahan kolom
                }
                Console.WriteLine("\n"); //new line / enter
                //perpindahan baris
            }
        }

        public static void PrintArray(string[] arr)
        {
            for (int col = 0; col < arr.Length; col++)
            {
                Console.Write(arr[col] + "\t");
                //perpindahan kolom
            }

        }
    }
}

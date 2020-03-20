using System;
namespace topik
{
    public class stringspangrams
    {
        public stringspangrams()
        {
            Console.WriteLine("----- SOAL 06 Pangrams -----");
            Console.Write("Input sentence : ");
            string input = Console.ReadLine();

            string pangram = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

                for (int i = 0; i < pangram.Length; i++)
                {
                    if (input.Contains(pangram.Substring(i, 1)))
                    {
                        count++;
                        break;
                    }
                }  

            if (count == 26)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
    }
}

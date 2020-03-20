using System;
namespace LOGIC03
{
    public class SOAL09
    {
        public SOAL09()
        {
            Console.Write("Masukkan jam : ");
            string[] jam = Console.ReadLine().Split(':');
            if (jam[2].Substring(jam[2].Length - 2, 2).ToUpper() == "PM")
            {
                jam[0] = (int.Parse(jam[0]) + 12).ToString();
            }
            else if (jam[2].Substring(jam[2].Length - 2, 2).ToUpper() == "AM")
            {
                if (int.Parse(jam[0]) > 12)
                {
                    Console.WriteLine("Salah masukin");
                }
            }
            jam[2] = jam[2].Substring(0, 2);
            Console.WriteLine(string.Join(":", jam));
            Console.ReadKey();
        }
    }
}

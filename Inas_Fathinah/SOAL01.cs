using System;
namespace Inas_Fathinah
{
    public class SOAL01
    {
        public SOAL01()
        {
            Console.WriteLine("--- SOAL 01 ---");
            Console.WriteLine("Masukkan kalimat 1 :");
            string kal1 = Console.ReadLine();
            /* And if you like midnight driving with the windows down,
            and if you like going places we can't even pronounce,
            if you like to do whatever you've been dreaming about,
            then, baby, you're perfect. Baby, you're perfect. So let's
            start right now */
            Console.WriteLine("Masukkan kalimat 2 :");
            string kal2 = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < kal1.Length; i++)
            {

                if (kal2.IndexOf(kal1.Substring(i, 1)) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Karakter yang sama = {0}", count);
        }
    }
}

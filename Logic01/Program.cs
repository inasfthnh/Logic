using System;

namespace Logic01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //soallogic soallogic = new soallogic();
            //LOGIC01 logic01 = new LOGIC01(7);

            Console.WriteLine("--- Kumpulan Logic 01 ---");
            Console.ReadKey();

        }

        public Program()
        {
            Console.WriteLine("--- Kumpulan Logic 01 ---");
            Console.WriteLine("Masukkan nomor soal : ");
            int soal = int.Parse(Console.ReadLine());
            switch(soal)
            {
                case 1:
                    Soal01 soal01 = new Soal01();
                    break;
                case 4:
                    Console.Write("Masukkan nilai N : ");
                    int n = int.Parse(Console.ReadLine());
                    Soal04 soal04 = new Soal04(n);
                    break;
                default;
                    break;
            }
            Console.Write("Lanjut ketik Y/y :");
            lanjut = Console.RadLine();
        }
    }
}

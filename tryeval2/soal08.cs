using System;
namespace tryeval2
{
    public class soal08
    {
        public soal08()
        {
            Console.WriteLine("SOAL 08");
            Console.WriteLine("SELAMAT DATANG DI ATM BANK ABC");
            Console.Write("Masukkan kartu anda");
            Console.ReadKey();
            Console.Write("Masukkan pin ATM : ");
            int pin = int.Parse(Console.ReadLine());
            int pinbnr = 123456;
            if (pin != pinbnr)
            {
                Console.WriteLine("PIN SALAH");
                Console.Write("PIN : ");
                int pin1 = int.Parse(Console.ReadLine());
            }

            int saldo = 0;
            Console.WriteLine("Masukkan uang yang disetor : ");
            int setor = int.Parse(Console.ReadLine());

            Console.WriteLine("Pilihan transfer (1 untuk antar rekening / 2 untuk antar bank) : ");
            int transfer = int.Parse(Console.ReadLine());

            if (transfer == 2)
            {
                Console.Write("Masukkan kode bank : ");
                int kode = int.Parse(Console.ReadLine());
            }
            Console.Write("Masukkan rekening tujuan (10 digit) ; ");
            string rek = Console.ReadLine();
            while(rek.Length == 10);

            Console.Write("Masukkan nominal transfer : ");
            int nominal = int.Parse(Console.ReadLine());

            
            if (transfer == 1)
            {
                saldo = setor - nominal;
            }
            else if (transfer == 2)
            {
                saldo = setor - nominal - 7500;
            }

            Console.WriteLine("Transaksi berhasil, saldo anda saat ini Rp {0},-", saldo);
        }
    }
}
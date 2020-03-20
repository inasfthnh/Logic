using System;
namespace Inas_Fathinah
{
    public class SOAL07
    {
        public SOAL07()
        {
            Console.WriteLine("--- SOAL 07 ---");
            String Kata = Console.ReadLine();
            String newKata = "";
            for (int i = 0; i < Kata.Length; i++)
            {
                if (Kata.Substring(i, 1) != " ")
                {
                    newKata += Kata.Substring(i, 1);
                }
            }
            int Ubah = Convert.ToInt32(Console.ReadLine());
            Console.Write(UbahKata(newKata, Ubah));
            Console.ReadKey();
        }

        public static StringBuilder UbahKata(String newKata, int Ubah)
        {
            int N = 1;
            StringBuilder Hasil = new StringBuilder();
            for (int i = 0; i < newKata.Length; i++)
            {
                if (i == 0)
                {
                    char chKata = (char)(((int)newKata[i] + Ubah - 65) % 26 + 65);
                    chKata = char.ToLower(chKata);
                    Hasil.Append(chKata);
                }
                else if (newKata[i] == '!')
                {
                    Hasil.Append('!');
                }
                else if (i % 3 == 0)
                {
                    Hasil.Append(N);
                    N += 2;
                }
                else if (char.IsUpper(newKata[i]))
                {
                    char chKata = (char)(((int)newKata[i] + Ubah - 65) % 26 + 65);
                    Hasil.Append(chKata);
                }
                else
                {
                    char chKata = (char)(((int)newKata[i] + Ubah - 97) % 26 + 97);
                    Hasil.Append(chKata);
                }
            }
            return Hasil; //rnh1rr3oh!
        }
    }
}

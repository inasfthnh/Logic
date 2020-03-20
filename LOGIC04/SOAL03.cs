using System;
namespace LOGIC04
{
    public class SOAL03
    {
        public SOAL03()
        {
            Console.Write("Masukkan password : ");
            string psw = Console.ReadLine();
            const string numbers = "0123456789";
            const string low = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string spc = "!@#$%^&*()_+-=";

            //0:bNum, 1:bLow, 2:bUpp, 3:bSpc
            int[] bResult = new int[4] { 0, 0, 0, 0 };

            for (int i = 0; i < psw.Length; i++)
            {
                bool match = false;
                //Cek number
                if (!match && bResult[0] == 0)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (psw.Substring(i, 1) == numbers.Substring(j, 1)) //(i,1) > indeks/urutan ke i, sebanyak 1 huruf
                        {
                            bResult[0] = 1;
                            match = true;
                            break;
                        }
                    }
                }

                if (!match && bResult[1] == 0)
                {
                    //Cek lower
                    for (int j = 0; j < low.Length; j++)
                    {
                        if (psw.Substring(i, 1) == low.Substring(j, 1))
                        {
                            bResult[1] = 1;
                            match = true;
                            break;
                        }
                    }
                }

                if (!match && bResult[2] == 0)
                {
                    //Cek upper
                    for (int j = 0; j < upper.Length; j++)
                    {
                        if (psw.Substring(i, 1) == upper.Substring(j, 1))
                        {
                            bResult[2] = 1;
                            match = true;
                            break;
                        }
                    }
                }

                if (!match && bResult[3] == 0)
                {
                    //Cek Special
                    for (int j = 0; j < spc.Length; j++)
                    {
                        if (psw.Substring(i, 1) == spc.Substring(j, 1))
                        {
                            bResult[3] = 1;
                            match = true;
                            break;
                        }
                    }
                }

                if (bResult[0] == 1 && bResult[1] == 1 && bResult[2] == 1 && bResult[3] == 1)
                    break;
            }

            int final = 0;
            for (int i = 0; i < bResult.Length; i++)
            {
                final += bResult[i];
            }

            Console.WriteLine("Hasilny adalah : {0}", final);
            Console.ReadKey();
        }


    }
}


/*
namespace LOGIC04
{
    class SOAL03
    {
        public SOAL03()
        {
            Console.WriteLine("Masukkan password :");
            string pass = Console.ReadLine();

            int temp = char.ConvertToUtf32;
            if (temp >= 65 && temp <= 90)
            {
                string upper;
            }
            if (temp >= 97 && temp <= 122)
            {
                string lower;
            }
            if (temp >= 48 && temp <= 57)
            {
                int nomor;
            }
            if (temp >= 33 && temp <= 47)
            {
                string spc;
            }
                string upper;
            string lower;
            int nomor = 0;
            string spc;

            int[] hasil = new int[4];
            hitung(upper,lower,nomor,spc);
        }

        private void hitung(string upper, string lower, int nomor, string spc)
        {
            int output = 0;
            for (int i = 0; i < Array1D.Length; i++)
            {
                    if (int.Parse(upper) > 0)
                    {
                        output++;
                    }
                }
               
                    if (int.Parse(lower) > 0)
                    {
                        output++;
                    }
                }
                
                    if (nomor > 0)
                    {
                        output++;
                    }
                }
                
                    if (int.Parse(spc) > 0)
                    {
                        output++;
                    }
                }
            }
            Console.WriteLine("banyak karakter" + output);

        }
    }
}
*/
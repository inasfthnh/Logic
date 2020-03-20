using System;
namespace Logic
{
    class soal01
    {
        //contoh oop encapsulation
        public soal01()
        {
            cetaktambah(5, 7);
            Console.WriteLine("Hasilnya adalah {0}", nilaitambah(6, 8));
            Console.ReadLine();
        }

        private void cetaktambah(int nil1, int nil2)
        {
            Console.WriteLine(String.Format("Hasilnya adalah {0} + {1} = {2}", nil1, nil2, nil1 + nil2));
        }


        private int nilaitambah(int nil1, int nil2)
        {
            return nil1 + nil2;
        }
    }
}

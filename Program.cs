using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void method(string[] args)
        {
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            Console.WriteLine(" ");
            Console.WriteLine("Daftar Menu Kalkulator");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 1. Penambahan |");
            Console.WriteLine("| 2. Pengurangan |");
            Console.WriteLine("| 3. Perkalian |");
            Console.WriteLine("| 4. Pembagian |");

            Console.WriteLine("+-------------------+");

            Console.Write("Masukan nilai pertama = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Maukan nilai kedua");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Silahkan Pilih menu kalkulator 1 sampai 4 =");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (menu > 4)
            {
                Console.WriteLine("Maaf Menu yang Anda Pilih salah atau tidak Tersedia!");
            }
            else
            {

            }
            switch (menu)
            {

                case 1:
                    Console.WriteLine("Hasil Penambahannya adalah " + a + " + " + b + " = " +
                        penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurannya adalah {0} - {1} = {2]", a, b,
                        pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkaliannya adalah {0} * {1} = {2}", a, b,
                        perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagiannya adalah {0} / {1} = {2}", a, b,
                        pembagian(a, b));
                    break;
            }
            Console.WriteLine("\n Tekan Enter untuk keluar");
            Console.ReadKey();
        }


    }
}

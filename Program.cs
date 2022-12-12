using System;
using System.Diagnostics;
using System.Globalization;

// REVISI
//1.menambahkan menu register dan login
//2.nim dan password harus sama
//3. tambahkan method non void

namespace BasicProgramming
{
    class ProgramLogika
    {
        public static void Main(string[] args)
        {
            ProgramLogika d1 = new ProgramLogika();
            d1.Display();
        }

        // void (Display)
        void Display()
        {

            Console.Write("Silahkan pilih :\n1.Register\n2.Login\n");
            Console.Write("Silahkan masukkan pilihan = ");
            var input = Console.ReadLine();
            string nim2 = "";
            string password2 = "";
            string username2 = "";
            bool doRepeat = false;
            do
            {

                if (input == "1")
                {
                    Console.WriteLine("\nMenu registrasi\n");

                    Console.Write("Masukkan username anda: ");
                    username2 = Console.ReadLine();

                    Console.Write("Silahkan masukkan nim anda: ");
                    nim2 = Console.ReadLine();

                    Console.Write("Silahkan masukkan password anda: ");
                    password2 = Console.ReadLine();
                }

                Console.WriteLine("\nSILAHKAN PILIH PROGRAM STUDI KALIAN");
                String[] prodi = { "TEKNIK", "Kedokteran", "Pendidikan" };

                for (int i = 0; i < prodi.Length; i++)
                {
                    Console.WriteLine((i + 1) + " " + prodi[i]);
                }

                Console.Write("\nMasukkan prodi anda: ");
                int prodi2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\n===================== PRODI " + (prodi[prodi2 - 1]) + " =====================");


                Console.WriteLine("\nMenu login\n");

                Console.Write("Masukkan username anda: ");
                string username = Console.ReadLine();

                Console.Write("Masukkan nim anda: ");
                string nim = Console.ReadLine();

                Console.Write("Masukkan tahun lahir anda: ");
                int tahunSekarang = Convert.ToInt16(DateTime.Now.Year.ToString());
                int tahunlahir = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Umur anda kurang lebih: " + umur(tahunSekarang,tahunlahir));

                Console.Write("Password: ");
                string password = Console.ReadLine();

                bool isusernameValid = username == username2;
                bool isNimValid = nim == nim2; // pernyataan 1
                bool isPasswordValid = password == password2; // pernyataan 2

                if (isNimValid && isPasswordValid && isusernameValid)  // menggunakan logika AND
                {
                    Console.WriteLine("\n!!! SELAMAT ANDA SUDAH LOGIN !!!");
                    doRepeat = false;
                }
                else
                {
                    Console.WriteLine("Yang anda masukkan salah...Dicoba lagi.");
                    Console.WriteLine();

                    Console.WriteLine("Apakah ingin mengulangi ? (Y / N)");
                    char ans = Convert.ToChar(Console.ReadLine());
                    if (ans == 'y' || ans == 'Y')
                    {
                        doRepeat = true;
                    }
                    else
                    {
                        doRepeat = false;
                    }
                }

            }
            while (doRepeat);
        }
        int umur(int sekarang, int lahir)
        {
            return sekarang - lahir;
        }

    }
}
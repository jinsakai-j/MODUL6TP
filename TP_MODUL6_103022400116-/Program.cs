using System;
using TP_MODUL6_103022400116;

namespace TP_MODUL6_103022400130
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Objek normal ===");
            try
            {
                SayaMusicTrack lagu1 = new SayaMusicTrack("Kabogoh Jauh");
                lagu1.IncreasePlayCount(5000);
                lagu1.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }

            Console.WriteLine("=== Uji precondition: title null ===");
            try
            {
                SayaMusicTrack lagu2 = new SayaMusicTrack(null);
                lagu2.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }

            Console.WriteLine("=== Uji precondition: title > 100 karakter ===");
            try
            {
                string judulPanjang = new string('A', 101);
                SayaMusicTrack lagu3 = new SayaMusicTrack(judulPanjang);
                lagu3.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }

            Console.WriteLine("=== Uji precondition: count > 10.000.000 ===");
            try
            {
                SayaMusicTrack lagu4 = new SayaMusicTrack("Lagu Uji");
                lagu4.IncreasePlayCount(15000000);
                lagu4.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }

            Console.WriteLine("=== Uji exception overflow ===");
            try
            {
                SayaMusicTrack lagu5 = new SayaMusicTrack("Lagu Overflow");

                for (int i = 0; i < 300; i++)
                {
                    lagu5.IncreasePlayCount(10000000);
                }

                lagu5.PrintTrackDetails();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow berhasil terdeteksi dan loop dihentikan.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}
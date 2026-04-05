using System;

namespace TP_MODUL6_103022400116
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string? title;

        public SayaMusicTrack(string? title)
        {
            if (title == null)
            {
                throw new ArgumentException("Judul track tidak boleh null");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Judul track maksimal 100 karakter");
            }

            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentException("Penambahan play count maksimal 10.000.000");
            }

            if (count < 0)
            {
                throw new ArgumentException("Penambahan play count tidak boleh negatif");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count");
                throw;
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID       : " + id);
            Console.WriteLine("Title    : " + title);
            Console.WriteLine("PlayCount: " + playCount);
            Console.WriteLine();
        }
    }
}
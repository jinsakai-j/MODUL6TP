using System;

namespace TP_MODUL6_103022400116
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000); // 5 digit
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Track ID     : " + id);
            Console.WriteLine("Track Title  : " + title);
            Console.WriteLine("Play Count   : " + playCount);
            Console.WriteLine("-----------------------------------");
        }
    }
}
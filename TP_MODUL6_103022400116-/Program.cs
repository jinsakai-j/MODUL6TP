using System;
using TP_MODUL6_103022400116;

namespace TP_MODUL6_103022400116
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Danger Line");

            lagu1.PrintTrackDetails();
            lagu1.IncreasePlayCount(5000);
            lagu1.PrintTrackDetails();
        }
    }
}
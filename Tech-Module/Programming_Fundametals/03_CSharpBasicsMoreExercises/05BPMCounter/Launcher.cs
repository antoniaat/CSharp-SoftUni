using System;

namespace _05BPMCounter
{
    // Program, which receives BPM (beats per minute) and number of beats from the console and calculates how many bars (1 bar == 4 beats) the beats equal to, then calculates the length of the sequence in minutes and seconds.
    public class Launcher
    {
        public static void Main()
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());
            var bars = numberOfBeats / 4.0;
            bars = Math.Round(bars, 1);
            var seconds = (numberOfBeats / (double)beatsPerMinute) * 60;
            seconds = Math.Truncate(seconds);
            var second = seconds % 60;
            var minutes = (int)seconds / 60;

            Console.WriteLine($"{bars} bars - {minutes}m {second}s");
        }
    }
}
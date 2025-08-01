using System;
using System.Linq;

namespace exercism
{
    internal class BirdCount
    {
        private int[] birdsPerDay;

        internal BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        internal static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

        internal int Today() => this.birdsPerDay[birdsPerDay.Length - 1];

        internal void IncrementTodaysCount() => this.birdsPerDay[this.birdsPerDay.Length - 1]++;

        internal bool HasDayWithoutBirds() => this.birdsPerDay.Contains(0);

        internal int CountForFirstDays(int numberOfDays)
        {
            if (numberOfDays < 1 || numberOfDays > 7) throw new ArgumentException("O valor informado é inválido");
            return birdsPerDay.Take(numberOfDays).Sum();
        }

        internal int BusyDays() => this.birdsPerDay.Count(x => x >= 5);
    }
}

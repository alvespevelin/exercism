using exercism.tasks;
using System;
namespace exercism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            int speed = 2;
            int batteryDrain = 10;
            var car = new RemoteControlCar(speed, batteryDrain);
            int distance = 20;
            var race = new RaceTrack(distance);
            result = race.TryFinishTrack(car).ToString();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
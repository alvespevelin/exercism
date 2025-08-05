using System;
namespace exercism
{
    public class RemoteControlCar
    {
        private int _distanceDriven = 0;
        private int _battery = 100;

        public int Speed { get; }
        public int BatteryDrain { get; }
        public int Battery => _battery;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            Speed = speed;
            BatteryDrain = batteryDrain;
        }

        public bool BatteryDrained() => _battery < BatteryDrain;
        public int DistanceDriven() => _distanceDriven;

        public void Drive()
        {
            if(!BatteryDrained())
            {
                _distanceDriven += Speed;
                _battery -= BatteryDrain;
            }
        }

        public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    }

    public class RaceTrack
    {
        private readonly int _distance;
        public RaceTrack(int distance)
        {
            _distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained())
            {
                car.Drive();
                if (car.DistanceDriven() >= _distance)
                    return true;
            }
            return false;
        }
    }
}



//class RemoteControlCar
//{
//    private int _distance;
//    private int _battery;

//    public RemoteControlCar()
//    {
//        _distance = 0;
//        _battery = 100;
//    }

//    public static RemoteControlCar Buy() => new RemoteControlCar();

//    public string DistanceDisplay() => $"Driven {_distance} meters";

//    public string BatteryDisplay() => _battery > 0 ? $"Battery at {_battery}%" : "Battery empty";

//    public void Drive()
//    {
//        if (_battery > 0)
//        {
//            _battery--;
//            _distance += 20;
//        }
//    }
//}
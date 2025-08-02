namespace exercism.tasks
{
    internal class RemoteControlCar
    {
        private int _distanceDriven;
        private int _batteryPercentage;
        private const int DriveDistancePerUse = 20;
        private const int MaxBattery = 100;

        public RemoteControlCar()
        {
            _distanceDriven = 0;
            _batteryPercentage = MaxBattery;
        }

        public static RemoteControlCar Buy() => new RemoteControlCar();

        public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

        public string BatteryDisplay() => _batteryPercentage > 0
            ? $"Battery at {_batteryPercentage}%"
            : "Battery empty";

        public void Drive()
        {
            if (_batteryPercentage <= 0) return;

            _distanceDriven += DriveDistancePerUse;
            _batteryPercentage--;
        }
    }
}

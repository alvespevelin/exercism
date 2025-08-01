namespace exercism
{
    internal class Lasagna
    {
        internal static int ExpectedMinutesInOven() => 40;
        
        internal static int RemainingMinutesInOven(int minPassed) => ExpectedMinutesInOven() - minPassed; 
        
        internal static int PreparationTimeInMinutes(int layers) =>  layers * 2;

        internal static int ElapsedTimeInMinutes(int layers, int minPassed) => PreparationTimeInMinutes(layers) + minPassed;
    }
}

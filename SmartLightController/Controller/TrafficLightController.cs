namespace SmartLightController
{
    public sealed class TrafficLightController
    {
        private static readonly Lazy<TrafficLightController> instance =
            new Lazy<TrafficLightController>(() => new TrafficLightController());

        public static TrafficLightController Instance => instance.Value;

        private TrafficLightController() { }

        public void AdjustLightDuration(int sideRoadGreenDuration, int sideRoadRedDuration)
        {
            Console.WriteLine($"Side road green light duration set to {sideRoadGreenDuration} seconds.");
            Console.WriteLine($"Side road red light duration set to {sideRoadRedDuration} seconds.");
        }

        public void AdjustMainRoadLightDuration(int mainRoadGreenDuration, int mainRoadRedDuration)
        {
            Console.WriteLine($"Main road green light duration set to {mainRoadGreenDuration} seconds.");
            Console.WriteLine($"Main road red light duration set to {mainRoadRedDuration} seconds.");
        }
    }
}

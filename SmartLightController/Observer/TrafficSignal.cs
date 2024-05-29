namespace SmartLightController
{
    public interface ITrafficObserver
    {
        void UpdateTrafficLight(string signal);
    }

    public class TrafficSignal : ITrafficObserver
    {
        public void UpdateTrafficLight(string signal)
        {
            Console.WriteLine($"Traffic signal updated to: {signal}");
        }
    }
}

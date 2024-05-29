namespace SmartLightController
{
    public class TrafficSensorProxy : ITrafficSensor
    {
        private readonly ITrafficSensor _realSensor;

        public TrafficSensorProxy(ITrafficSensor realSensor)
        {
            _realSensor = realSensor;
        }

        public void DetectTraffic()
        {
            // Add proxy functionality (e.g., access control, caching)...
            _realSensor.DetectTraffic();
        }
    }
}

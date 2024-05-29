namespace SmartLightController
{
    public interface ITrafficSensor
    {
        void DetectTraffic();
    }

    public class VehicleSensor : ITrafficSensor
    {
        public void DetectTraffic()
        {
            Console.WriteLine("Vehicle traffic detected by vehicle sensor.");
        }
    }

    public class PedestrianSensor : ITrafficSensor
    {
        public void DetectTraffic()
        {
            Console.WriteLine("Pedestrian movement detected by pedestrian sensor.");
        }
    }

    public abstract class SensorFactory
    {
        public abstract ITrafficSensor CreateSensor();
    }

    public class VehicleSensorFactory : SensorFactory
    {
        public override ITrafficSensor CreateSensor() => new VehicleSensor();
    }

    public class PedestrianSensorFactory : SensorFactory
    {
        public override ITrafficSensor CreateSensor() => new PedestrianSensor();
    }
}

using SmartLightController;

class Program
{
    static void Main(string[] args)
    {
        // Singleton usage
        TrafficLightController trafficLightController = TrafficLightController.Instance;

        // Factory Method usage
        SensorFactory sensorFactory = new VehicleSensorFactory();
        ITrafficSensor sensor = sensorFactory.CreateSensor();

        // Observer usage
        TrafficSignal trafficSignal = new TrafficSignal();
        // Assume method to attach observer exists
        // trafficLightController.AttachObserver(trafficSignal);

        // Adapter usage
        ExternalTrafficData externalData = new ExternalTrafficData();
        externalData.FetchTrafficData();
        ITrafficData trafficData = new TrafficDataAdapter(externalData);

        // Proxy usage
        ITrafficSensor sensorProxy = new TrafficSensorProxy(sensor);
        sensorProxy.DetectTraffic();

        // Strategy usage
        ITrafficManagementStrategy strategy = new NormalTrafficStrategy();
        // MVC usage
        TrafficModel model = new TrafficModel();
        TrafficView view = new TrafficView();
        TrafficController mvcController = new TrafficController(model, view, strategy);

        // Update model and view based on traffic data
        model.TrafficData = "Initial traffic data";
        mvcController.UpdateView();

        // Change strategy and update view
        strategy = new HighTrafficStrategy();
        mvcController.SetStrategy(strategy);
        mvcController.ExecuteStrategy();
    }
}
namespace SmartLightController
{
    public interface ITrafficManagementStrategy
    {
        void Execute();
    }

    public class NormalTrafficStrategy : ITrafficManagementStrategy
    {
        public void Execute()
        {
            // Normal trafik stratejisi için trafik ışıklarının zamanlamasını ayarlayın.
            // Bu, örneğin, tüm yollar için standart yeşil ve kırmızı ışık sürelerini ayarlayarak yapılabilir.

            TrafficLightController trafficLightController = TrafficLightController.Instance;

            // Tüm yollar için standart yeşil ve kırmızı ışık sürelerini ayarla.
            trafficLightController.AdjustLightDuration(sideRoadGreenDuration: 30, sideRoadRedDuration: 30);

            // Trafik yoğunluğu verilerini güncelleyin veya loglayın.
            Console.WriteLine("Normal traffic strategy executed: Standard light timing set.");
        }
    }

    public class HighTrafficStrategy : ITrafficManagementStrategy
    {
        // Örnek olarak, yüksek trafikte yeşil ışığın süresini artıracağız.
        public void Execute()
        {
            // Yüksek trafik stratejisi için trafik ışıklarının zamanlamasını ayarlayın.
            // Bu, örneğin, ana yolların yeşil ışık süresini artırarak ve yan yollarınkini azaltarak yapılabilir.
            // Not: TrafficLightController ve AdjustLightDuration metotları hayali ve örnek amaçlıdır.

            TrafficLightController trafficLightController = TrafficLightController.Instance;

            // Ana yollar için yeşil ışık süresini artır.
            trafficLightController.AdjustMainRoadLightDuration(mainRoadGreenDuration: 60, mainRoadRedDuration: 30);

            // Yan yollar için yeşil ışık süresini azalt.
            trafficLightController.AdjustLightDuration(sideRoadGreenDuration: 30, sideRoadRedDuration: 60);

            // Trafik yoğunluğu verilerini güncelleyin veya loglayın.
            Console.WriteLine("High traffic strategy executed: Increased green light duration for main roads.");
        }
    }
}

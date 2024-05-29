namespace SmartLightController
{
    public interface ITrafficData
    {
        void ProcessTrafficData();
    }

    public class TrafficDataAdapter : ITrafficData
    {
        private readonly ExternalTrafficData _externalData;

        public TrafficDataAdapter(ExternalTrafficData externalData)
        {
            _externalData = externalData;
        }

        public void ProcessTrafficData()
        {
            // Örnek olarak, alınan verileri işleyerek trafik yoğunluğu seviyelerini hesaplayalım.
            string mainRoadCongestionLevel = DetermineCongestionLevel(_externalData.MainRoadTrafficVolume);
            string sideRoadCongestionLevel = DetermineCongestionLevel(_externalData.SideRoadTrafficVolume);

            // İşlenen verileri konsola yazdıralım (veya gerektiği gibi başka bir yere iletebiliriz).
            Console.WriteLine($"Main Road Congestion Level: {mainRoadCongestionLevel}");
            Console.WriteLine($"Side Road Congestion Level: {sideRoadCongestionLevel}");
        }

        // Trafik yoğunluğu verilerine dayanarak trafik sıkışıklık seviyesini belirleyen metod
        private string DetermineCongestionLevel(int trafficVolume)
        {
            // Basit bir yoğunluk seviyesi hesaplama örneği.  
            if (trafficVolume < 30)
                return "Low";
            else if (trafficVolume < 70)
                return "Medium";
            else
                return "High";
        }
    }
}

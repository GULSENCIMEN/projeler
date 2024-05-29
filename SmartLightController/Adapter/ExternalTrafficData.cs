namespace SmartLightController
{
    public class ExternalTrafficData
    {
        // Harici sistemden alınan trafik yoğunluğu verilerini temsil eden özellikler
        public int MainRoadTrafficVolume { get; private set; }
        public int SideRoadTrafficVolume { get; private set; }
        public DateTime DataRetrievedTime { get; private set; }

        // Örnek metot: Dış kaynaktan trafik verilerini al
        public void FetchTrafficData()
        {
            // Gerçek bir uygulamada, burada bir API çağrısı veya veri akışı yapılabilir
            // Şu an için örnek veri ile simüle edelim
            MainRoadTrafficVolume = GetRandomTrafficVolume();
            SideRoadTrafficVolume = GetRandomTrafficVolume();
            DataRetrievedTime = DateTime.Now;

            // Veri alındığında bilgilendirme yapalım
            Console.WriteLine($"Traffic data fetched at {DataRetrievedTime}.");
            Console.WriteLine($"Main Road Traffic Volume: {MainRoadTrafficVolume}");
            Console.WriteLine($"Side Road Traffic Volume: {SideRoadTrafficVolume}");
        }

        // Rastgele trafik hacmi üreten özel metot
        private int GetRandomTrafficVolume()
        {
            Random random = new Random();
            return random.Next(0, 100); // 0 ile 100 arasında rastgele bir trafik hacmi değeri döndür
        }
    }
}

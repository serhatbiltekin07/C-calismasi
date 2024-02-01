namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Biltekin";
            musteri1.LastName = "Kurtuluş";
            musteri1.phone = "555555555";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "AhmetAli";
            musteri2.LastName = "Kar";
            musteri2.phone = "444444444";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.Name = "Tolga";
            musteri3.LastName = "Noyan";
            musteri3.phone = "99999999";

            List<Musteri> musteriler = new List<Musteri> { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (var item in musteriler)
            {
                musteriManager.Ekle(item);
            }
            Console.WriteLine("-------------------------------------------------------------");
            foreach (var item in musteriler)
            {
                musteriManager.List(item);
            }

            Console.WriteLine("-------------------------------------------------------------");

            foreach (var item in musteriler)
            {
                musteriManager.Sil(item);
            }
        }
    }
}

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();    
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elma";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Limon";
            product2.Fiyati = 10;
            product2.Aciklama = "Rize Limonu";

            Product product3 = new Product();
            product3.Id = 3;
            product3.Adi = "Karpuz";
            product3.Fiyati = 80;
            product3.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2,product3 };

            //type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("-------------------Metotlar---------------------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır armut", 12,8);

        }
    }
}

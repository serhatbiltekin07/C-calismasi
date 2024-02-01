namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Category = "İŞLEMCİ";
            product1.Name = "İntel";
            product1.Detail = "i3 13100f";
            product1.Stock = 1000;

            Product product2 = new Product();
            product2.Category = "EKRAN KARTI";
            product2.Name = "Msi";
            product2.Detail = "RTX 4080Tİ";
            product2.Stock = 2200;

            Product product3 = new Product();
            product3.Category = "ANAKART";
            product3.Name = "Gigabyte";
            product3.Detail = "H610M-K-DDR4 ";
            product3.Stock = 7600;

            Product product4 = new Product();
            product4.Category = "RAM";
            product4.Name = "CORSAIR";
            product4.Detail = "16GB Vengeance LPX 5200MHz CL40 DDR5";
            product4.Stock = 9200;


            Product[] products = new Product[] { product1, product2, product3, product4 };

            foreach (var product in products)
            {
                Console.WriteLine("Kategori :"+" "+product.Category);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Adı :"+" "+product.Name);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Detay :" +" "+product.Detail);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Adet :"+" "+product.Stock);
                Console.WriteLine("---------------------------------------");
            }

        }
    }
}

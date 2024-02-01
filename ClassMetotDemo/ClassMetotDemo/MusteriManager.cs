using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager 
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri :"+ musteri.Name+" "+ musteri.LastName);
            Console.WriteLine("Müşteri numarası: "+ musteri.phone);
            Console.WriteLine("Eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri :" + musteri.Name + " " + musteri.LastName);
            Console.WriteLine("Müşteri numarası: " + musteri.phone);
            Console.WriteLine("Silindi.");
        }
         
        
        public void List(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri :" + musteri.Name + " " + musteri.LastName);
            Console.WriteLine("Müşteri numarası: " + musteri.phone);
            Console.WriteLine("Listelendi.");
        }
    }
}

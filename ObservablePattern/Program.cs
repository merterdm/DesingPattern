namespace ObservablePattern
{
    internal class Program
    {
        
        /*
            Observer tasarım deseni behavior grubununa ait, bir nesnede meydana gelen değişikliklerde içinde bulundurduğu listede bulunan nesnelere haber gönderen tasarım desenidir. Observer tasarım deseninin uluslar arası kullanıma  göre en sık kullanılan tasarım desenlerindendir. 

            Observer tasarım deseni; birbirleri ile bire çok (yani bir nesnenin içinde başka bir nesnenin listesinin bulunması olarak düşünebiliriz) ilişki olan nesneler arasında olay bazlı bir etkileşim olduğu durumları düzenler. Örnek senaryo olarak;

            Bir e-ticaret sitesinde bir üründeki stok değişiminde o ürünü takip eden üyelere haber verilmesi.

            Ham madde – ürün ilişkisi olan bir durumda, ham maddenin fiyatı değişince ürünün fiyatının da değişmesi.

            Facebook da ki bir iletiye yorum yapılması durumunda o iletiye yorum yapan ve beğenen üyelere bildirim gitmesi

            Subject:Takip edilecek nesneyi Subject terimiyle ifade etmekteyiz.

            Observer:Subject’i takip edecek olan aboneler tek tip olmayabilirler.İşte böyle bir durumda birden fazla tipe arayüz görevi görecek abstract yahut interface yapımıza Observer denmektedir. 

            Concrete:Subject’i takip eden nesnelerdir.

             */
        static void Main(string[] args)
        {
            //ilk olarak subject nesnemiz 
            absUrun IPhone = new Urun("IPhone", 20000);
            IPhone.TakipListesi.Add(new Uye() { Email = "ali@gmail.com" });
            IPhone.TakipListesi.Add(new Uye() { Email = "veli@gmail.com" });
            IPhone.TakipListesi.Add(new Uye() { Email = "ayse@gmail.com" });
            IPhone.TakipListesi.Add(new Uye() { Email = "fatma@gmail.com" });
            
            IPhone.Fiyat = 18000;



            Console.WriteLine("Hello, World!");
        }
    }
}
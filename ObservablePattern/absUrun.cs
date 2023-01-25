using System.Security.Cryptography;

namespace ObservablePattern
{
    public class absUrun
    {

        public string UrunAdi { get; set; }
        private decimal _fiyat;

        //Observer nesne listesi: Yani Gozlemciler burada
        public List<IUye> TakipListesi = new List<IUye>();
        public absUrun(string UrunAdi,decimal urunFiyat)
        {
            _fiyat= urunFiyat;
            this.UrunAdi=UrunAdi.Trim();

        }

        public decimal  Fiyat
        {
            get { return _fiyat; } 
            set { 
                //Eger fiyat dustu ise uyele mail gitsin
                if (_fiyat > value)
                {
                    
                    _fiyat = value;
                    UyelerBildir();
                    
                }
            
            }

        
        }

        private void UyelerBildir()
        {
            foreach (var uye in TakipListesi)
            {
                uye.Update(this);
            }
        }
    }
}
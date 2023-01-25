using AdapterPattern.Lab1.Abstract;
using AdapterPattern.Lab1.Concrete;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                  Adapter tasarım deseni structural grubuna aittir. uluslar arası standartlarda %80 olaslıkla 
                  kullanıldığı gözlenmiştir. Uygulama içerisinde ki bir yapıya dışarıdaki bir yapıyı duzenleyen 
                  tasarım desenidir. 

                Bazı durumlarda zaten var olan başka bir yapıyı uygulamamız içinde ki bir yapıya uyarlayıp kullanmamız gerekebilir. 
                Burada uyarlanacak yapı net kütüphanesi olması gerekmez. Com nesnesi gibi bir yapı da olabilir veya 
                zaten geliştirdiğimiz uygulamadaki başka bir yapı da olabilir. 
                Bu uyarlama işlemini yazacağımız bir Adapter nesnesi ile sağlayabiliriz.

            */

            #region Lab1

            Uyarlayici uyarlayici = new Uyarlayici();
            Console.WriteLine(uyarlayici.SpecialRequest(5,3));

            ITarget target = new Adaptor();
            Console.WriteLine(target.Request(5));

            #endregion

            string str = """
                <html>
                    <head>
                        <title> Denemem </title>
                    </head>
                </html>
                """;

            Console.WriteLine(str);
        }
    }
}
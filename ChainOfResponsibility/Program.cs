using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;

namespace ChainOfResponsibility
{
    internal class Program
    {
        /*
         
            Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni behavior grubununa ait, 
            bir isteğin belli sınıflar içinde gezdirilerek ilgili sınıfın işlem yapmasını yöneten tasarım desenidir. 
            Chain of responsibility tasarım deseninin uluslar arası kullanıma göre kullanım sıklığı 40% lardadır. 

            Chain of responsibility tasarım deseni; bir isteğin duruma göre farklı şekillerde işlem yapılması gereken 
            durumlarda kullanılır. Bu tasarım deseninde isteğe cevap verebilecek sınıflar aynı arayüzü kullanır ve 
            isteğin durumuna göre ya cevap verir ya da isteği zincirdeki sonraki nesneye gönderir.
             
            Handler: İsteği işleyebilecek sınıfların uygulaması gereken interface veya abstract sınıftır. 
            Yani zincirdeki bütün halkalar bu arayüzü uygulamak zorundadır. 
            Bu arayüzde kendisini gösteren bir property ve isteğe cevap verebilecek bir metot tanımlı olur.

            ConcreteHandler: İsteğe cevap verebilecek (veya sonraki nesneye yönlendirebilecek) gerçek sınıflardır. 
            Bu sınıfların hepsi Handler olarak tanımlanan arayüzü uygulamak zorundadır.

            Client: Zincirin oluşturan ve zincirin ilk halkasına isteği gönderen nesnedir.
             */
        static void Main(string[] args)
        {

            /*
             Zincirin Haklarini Tanimliyoruz
             
             */

            PlayerHandler mp3Player = new MP3Player();
            PlayerHandler mp4Player = new MP4Player();
            PlayerHandler midiPlayer = new MIDIPlayer();
            PlayerHandler aviPlayer = new AVIPlayer();
            
            // Zincirin halkarini birbirine bagliyoruz
            mp3Player.SonrakiPlayerHandler = mp4Player;
            mp4Player.SonrakiPlayerHandler= aviPlayer;
            aviPlayer.SonrakiPlayerHandler = midiPlayer;

            mp3Player.Play("test.avi");



            Console.WriteLine("Hello, World!");
        }
    }
}
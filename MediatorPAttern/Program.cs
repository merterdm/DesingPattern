namespace MediatorPAttern
{
    internal class Program
    {

            /*

                Mediator design pattern (aracı tasarım deseni), behavior grubununa ait, çalışmaları birbirleri ile aynı 
                arayüzden türeyen nesnelerin durumlarına bağlı olan nesnelerin davranışlarını düzenleyen tasarım desenidir. uluslar arası kullanıma göre kullanım oranı %40 civarındadır. 

                Bazı durumlarda nesnelerin davranışları kendi türünden başka nesnelere bağlı olabilir. 
                Mediator tasarım deseni birbirleri ile ilişkili olan bu nesneler arasında ki iletişimin ana bir 
                nesne üzerinden (mediator) yapılmasını sağlar. Böylece nesneler arasındaki bağ zayıflatılır ve 
                geliştirme aşamasında kod karmaşasını önler ve kodun yönetilmesini kolaylaştırır.


                Mediator: Nesneler arasındaki ilişkiyi sağlayacak metotların tanımlı olduğu arayüz.

                ConcreteMediator: Nesneler arasındaki ilişkiyi sağlayacak gerçek nesnedir. 
                Mediator arayüzünü uygular. İçinde Colleague ara yüzünden türeyen nesnelerin listesini barındırır.

                Colleague: ConcreteMediator u kullanarak işlem gerçekleştirecek olan nesnelerin uygulaması gereken 
                arayüzü temsil eder. Kendi içinde ConcreteMediator nesnesi barındırır.

                ConcreteColleague: ConcreteMediator üzerinden birbirleri ile ilişkili nesnelerdir. 
                Colleague arayüzünü uygularlar.
                 */
            static void Main(string[] args)
            {
                IChatMediator chatMediator=new ChatMediator();

            IUser ali = new BasicUser(chatMediator, "Ali");
            IUser veli= new PremiumUser(chatMediator, "Veli");
            IUser ayse = new BasicUser(chatMediator, "Ayse");
            IUser fatma = new PremiumUser(chatMediator, "Fatma");


            chatMediator.AddUser(ali);
            chatMediator.AddUser(veli);
            chatMediator.AddUser(ayse);
            chatMediator.AddUser(fatma);

            //Mesaj Gondermek istedigimde 
            ali.SendMessage("Naber millet !!");


            Console.ReadLine();
            }
    }
}
namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creater creater = new Creater();
            //MobileApplication androidApp = creater.FactoryMetod(AllMobileType.Android);
            //MobileApplication iosApp = creater.FactoryMetod(AllMobileType.IOS);
            //MobileApplication huaweiApp = creater.FactoryMetod(AllMobileType.HarmanyOS);


            //androidApp.Platform();
            //iosApp.Platform();
            //huaweiApp.Platform();

            NewCreater creater = new NewCreater();

            MobileApplication androidApp = creater.GetMobileApplication(AllMobileType.Android);
            MobileApplication iosApp = creater.GetMobileApplication(AllMobileType.IOS);
            MobileApplication huaweiApp = creater.GetMobileApplication(AllMobileType.HarmanyOS);

            androidApp.Platform();
            iosApp.Platform();
            huaweiApp.Platform();

            Console.WriteLine("Hello, World!");
        }
    }
}
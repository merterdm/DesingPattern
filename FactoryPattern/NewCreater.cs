using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NewCreater
    {

        public MobileApplication GetMobileApplication(AllMobileType allMobileType)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t=>t.Name == allMobileType.ToString());
            MobileApplication app= (MobileApplication)Activator.CreateInstance(type);

            return app;

        }

        
    }
}

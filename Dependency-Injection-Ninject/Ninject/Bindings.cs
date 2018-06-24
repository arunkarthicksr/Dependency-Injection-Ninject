using Dependency_Injection_Ninject.Classes;
using Dependency_Injection_Ninject.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            //Bind<IMailer>().To<PersonalMailer>();
            Bind<IMailer>().To<BusinessMailer>();

            //Bind<ILogger>().To<ConsoleLogger>();
            Bind<ILogger>().To<FileLogger>();
        }
    }
}

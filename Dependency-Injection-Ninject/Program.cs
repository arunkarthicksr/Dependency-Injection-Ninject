using Dependency_Injection_Ninject.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ninject Code
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailer = kernel.Get<IMailer>();

            //IMailer mailer = new PersonalMailer();
            //IMailer mailer = new BusinessMailer();
            //PersonalMailer mailer = new PersonalMailer();
            //BusinessMailer mailer = new BusinessMailer();

            //ILogger logger = new ConsoleLogger();
            //IMailer mailer = new PersonalMailer(logger);

            //ILogger logger = new FileLogger();
            //IMailer mailer = new PersonalMailer(logger);

            //IMailer mailer = new BusinessMailer();
            //PersonalMailer mailer = new PersonalMailer();
            //BusinessMailer mailer = new BusinessMailer();

            mailer.SendMail("Joker@supervillain.com", "You are just a garbage, who kills for money!");
            Console.ReadLine();
        }
    }
}

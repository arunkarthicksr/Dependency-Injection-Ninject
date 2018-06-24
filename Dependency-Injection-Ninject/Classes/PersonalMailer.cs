using Dependency_Injection_Ninject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject.Classes
{
    class PersonalMailer : IMailer
    {
        private ILogger _logger;
        public PersonalMailer(ILogger logger)
        {
            _logger = logger;

        }
        public void SendMail(string toAddress, string messageBody)
        {
            Console.WriteLine($"From: BruceWayne@superhero.com\nTo: {toAddress}\n\nHi {toAddress.Split('@')[0]},\n{messageBody}\nCheers,\nBruce Wayne\n");
            _logger.Log("Mail sent from Personal Email");
        }
    }
}

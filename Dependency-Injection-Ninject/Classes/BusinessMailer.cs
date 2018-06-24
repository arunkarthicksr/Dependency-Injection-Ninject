using Dependency_Injection_Ninject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject.Classes
{
    class BusinessMailer : IMailer
    {
        private ILogger _logger;
        public BusinessMailer(ILogger logger)
        {
            _logger = logger;

        }
        public void SendMail(string toAddress, string messageBody)
        {
            Console.WriteLine($"From: WayneEnterprise@company.com\nTo: {toAddress}\n\nHi {toAddress.Split('@')[0]},\n{messageBody}\nCheers,\nWayne Ent.\n");
            _logger.Log("Mail sent from Business Account");
        }
    }
}

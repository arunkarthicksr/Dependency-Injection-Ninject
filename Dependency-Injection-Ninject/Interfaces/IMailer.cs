using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject.Interfaces
{
    interface IMailer
    {
        void SendMail(string toAddress, string messageBody);
    }
}

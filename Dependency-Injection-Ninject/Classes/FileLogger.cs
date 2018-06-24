﻿using Dependency_Injection_Ninject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Ninject.Classes
{
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log message saved! {DateTime.Now.ToLongDateString()} - {message}");
        }
    }
}

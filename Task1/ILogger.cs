using System;
using System.Collections.Generic;
using System.Text;

namespace Task1and2
{
    internal interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}

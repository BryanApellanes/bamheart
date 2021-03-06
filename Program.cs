﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Net.Testing;

namespace Bam.Net.Application
{
    [Serializable]
    public class Program : CommandLineTool
    {
        static void Main(string[] args)
        {
            TryWritePid(true);
            IsolateMethodCalls = false;
            AddSwitches(typeof(ConsoleActions));
            AddConfigurationSwitches();
            ExecuteMainOrInteractive(args);
        }
    }
}

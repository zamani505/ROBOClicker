using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOClicker.Service
{
    public class HelpService
    {
        public string ReadHelp(string name)
        {
            var h= File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + name);
            return h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOClicker.Service
{
    public class IPCatchService
    {
        public static List<string> IpCatch = new List<string>();

        public void Add(string ip)
        {
            if (IpCatch.FirstOrDefault(o => o.Equals(ip)) == null)
                IpCatch.Add(ip);
        }

        public bool Exist(string ip)
            => IpCatch.FirstOrDefault(o => o.Equals(ip)) == null;

    }
}

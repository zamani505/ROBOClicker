using System;
using System.IO;
using Newtonsoft.Json;
using ROBOClicker.Model;
namespace ROBOClicker.Service
{
    public class SaveData
    {
        #region Vpn
        public Vpn ReadVpnSetting()
        {
            var js = File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "rba.dll");
            return js.Length > 0 ? JsonConvert.DeserializeObject<Vpn>(js) : null;
        }

        public void WriteVpnSetting(Vpn vpn)
        {
            using (var stream = new StreamWriter(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "rba.dll"))
            {
                stream.Write(JsonConvert.SerializeObject(vpn));
            }
        }
        #endregion
        #region Site
        public Site ReadSiteSetting()
        {
            var js = File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "ssl.dll");
            return js.Length > 0 ? JsonConvert.DeserializeObject<Site>(js) : null;
        }

        public void WriteSiteSetting(Site site)
        {
            using (var stream = new StreamWriter(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "ssl.dll"))
            {
                stream.Write(JsonConvert.SerializeObject(site));
            }
        }
        #endregion

    }
}

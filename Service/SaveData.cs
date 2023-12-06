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
        #region Reportage
        public Reportage ReadReportageSetting()
        {
            var js = File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "rpt.dll");
            return js.Length > 0 ? JsonConvert.DeserializeObject<Reportage>(js) : null;
        }

        public void WriteReportageSetting(Reportage reportage)
        {
            using (var stream = new StreamWriter(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "rpt.dll"))
            {
                stream.Write(JsonConvert.SerializeObject(reportage));
            }
        }
        #endregion
        #region RoboSetting
        public RoboSetting ReadRoboSetting()
        {
            var js = File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "robo.dll");
            return js.Length > 0 ? JsonConvert.DeserializeObject<RoboSetting>(js) : null;
        }

        public void WriteReportageSetting(RoboSetting roboSetting)
        {
            using (var stream = new StreamWriter(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "robo.dll"))
            {
                stream.Write(JsonConvert.SerializeObject(roboSetting));
            }
        }
        #endregion
        #region ScriptFile
        public ScriptFiles ReadScriptFile()
        {
            var js = File.ReadAllText(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "scf.dll");
            return js.Length > 0 ? JsonConvert.DeserializeObject<ScriptFiles>(js) : null;
        }

        public void WriteScriptFile(ScriptFiles scriptFiles)
        {
            using (var stream = new StreamWriter(Environment.CommandLine.Substring(1, Environment.CommandLine.LastIndexOf('\\')) + "scf.dll"))
            {
                stream.Write(JsonConvert.SerializeObject(scriptFiles));
            }
        }
        #endregion
    }
}

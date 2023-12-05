using System;
using System.Net;
using DotRas;
using Microsoft.Win32;
namespace ROBOClicker.Service
{
    public class CreateConnection
    {
        public static RasDialer _Dialer = new RasDialer();

        public string CreateVPN(string name, string destination)
        {
            try
            {
                RasPhoneBook PhoneBook = new RasPhoneBook();
                PhoneBook.Open();
                RasVpnStrategy strategy = RasVpnStrategy.L2tpOnly;  // Set your strategy here
                RasEntry VPNEntry = RasEntry.CreateVpnEntry(name, destination, strategy,
                    DotRas.RasDevice.Create(name, DotRas.RasDeviceType.Vpn));
                
                PhoneBook.Entries.Add(VPNEntry);
                _Dialer = new RasDialer();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "Create VPN Success!";
        }
        public string ConnectVPN(string name, string userName, string pwd)
        {
            try
            {
                RasPhoneBook PhoneBook = new RasPhoneBook();
                PhoneBook.Open();
                _Dialer.EntryName = name;
                _Dialer.PhoneBookPath = PhoneBook.Path;
                _Dialer.Credentials = new NetworkCredential(userName, pwd);
                _Dialer.DialAsync();
                
                FixReg();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "Connect to VPN Success!";


        }
        public string DisconnectVPN()
        {
            try
            {
                _Dialer.DialAsyncCancel();
                _Dialer.Dispose();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "Disconnect to VPN Success!";


        }

        public void FixReg()
        {
            const string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PolicyAgent";
            const string valueName = "AssumeUDPEncapsulationContextOnSendRule";
            const int value = 2;

            Registry.SetValue(keyName, valueName, value);
        }
    }
}

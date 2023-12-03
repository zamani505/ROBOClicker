using System;
using System.Net;
using DotRas;
using Microsoft.Win32;
namespace ROBOClicker.Service
{
    public class CreateConnection
    {
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

                RasDialer dialer = new RasDialer();
                dialer.EntryName = name;
                dialer.PhoneBookPath = PhoneBook.Path;
                dialer.Credentials = new NetworkCredential(userName, pwd);
                dialer.Dial();
                FixReg();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "Connect to VPN Success!";


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

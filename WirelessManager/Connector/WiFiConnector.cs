using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;
using SimpleWifi;

namespace WirelessManager.Connector
{
    sealed class WiFiConnector
    {
        private static WiFiConnector _instance;
        public static WiFiConnector GetInstance() { return _instance ?? (_instance = new WiFiConnector()); }

        public bool Connect(string name, string password)
        {
            var wifi = new Wifi();
            var selectedAP = wifi.GetAccessPoints().First(p => p.Name == name.Trim((char)0));
            if (selectedAP != null)
            {
                var authRequest = new AuthRequest(selectedAP);
                if (authRequest.IsPasswordRequired)
                {
                    authRequest.Password = password;
                }
                return selectedAP.Connect(authRequest);
            }
            return false;
        }
    }
}

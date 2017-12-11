using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WirelessManager.Network;
using WirelessManager.Scanner;

namespace WirelessManager.Dispatcher
{
    class WiFiDispatcher
    {
        public WiFiDispatcher() { Update(); }
        private WiFiScanner scanner = new WiFiScanner();
        public List<WiFiNetwork> Networks { get; private set; }
        public List<WiFiNetwork> Update()
        {
            return Networks = scanner.UpdateNetworks();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WirelessManager.Dispatcher;

namespace WirelessManager
{
    public partial class WirelessManagerForm : Form
    {
        private WiFiDispatcher dispatcher = WiFiDispatcher.GetInstance();
        public WirelessManagerForm()
        {
            InitializeComponent();
            NetworksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NetworksGridView.MultiSelect = false;
            UpdateData();
        }


        private void UpdateData()
        {
            var networks = dispatcher.Networks;
            NetworksGridView.Rows.Clear();
            foreach(var network in networks)
            {
                NetworksGridView.Rows.Add(network.Name, network.ConnectionQuality, network.AuthenticationType, network.MAC);
            }
        }
    }
}

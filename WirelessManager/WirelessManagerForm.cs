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
using WirelessManager.Updater;

namespace WirelessManager
{
    public partial class WirelessManagerForm : Form
    {
        private WiFiDispatcher _dispatcher = WiFiDispatcher.GetInstance();
        private DataUpdater _updater;
        public WirelessManagerForm()
        {
            InitializeComponent();
            NetworksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NetworksGridView.MultiSelect = false;
            this._updater = new DataUpdater(this);
        }


        public void UpdateData()
        {
            var networks = _dispatcher.Networks;
            NetworksGridView.Rows.Clear();
            foreach(var network in networks)
            {
                NetworksGridView.Rows.Add(network.Name, network.ConnectionQuality, network.AuthenticationType, network.MAC);
            }
        }

        private void WirelessManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updater.IsInterrupted = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTiana
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            FormServices services = new FormServices();
            services.Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            FormContracts contracts = new FormContracts();
            contracts.Show();
        }

        private void buttonAddedClients_Click(object sender, EventArgs e)
        {
            FormAddedClients addedClients = new FormAddedClients();
            addedClients.Show();
        }
    }
}

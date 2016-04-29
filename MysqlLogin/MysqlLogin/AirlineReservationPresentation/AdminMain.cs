using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MysqlLogin.AirlineReservationPresentation;

namespace MysqlLogin.AirlineReservationPresentation
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPassenger ap = new AddPassenger();
            ap.ShowDialog();
        }

        private void addAirlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlight al = new AddFlight();
            al.ShowDialog();
        }

        private void deleteAirlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePassenger dp = new DeletePassenger();
            dp.ShowDialog();
        }

        private void deleteAirlinesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAirline dl = new DeleteAirline();
            dl.ShowDialog();
        }

        private void addCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCrew ac = new AddCrew();
            ac.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();


        }
    }
}

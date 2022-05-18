using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _6SigmaSoruProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();

            

        }

        private void button_SinavSorumlusu_Click(object sender, EventArgs e)
        {
            SınavSorumlusuForm sınavSorumlusuForm = new SınavSorumlusuForm();
            sınavSorumlusuForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenciForm = new OgrenciForm();
            ogrenciForm.Show();
            this.Hide();
        }

        private void button_YeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayitForm yeniKayitForm = new YeniKayitForm();
            yeniKayitForm.Show();
            this.Hide();
        }
    }
}

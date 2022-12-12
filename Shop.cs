using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectTetris2
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            salutare.Text = "Bine ai venit la Shop, " + Program.contActual.username + "!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meniu m = new Meniu();
            m.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

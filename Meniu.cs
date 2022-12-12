using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace ProiectTetris2
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            string[] pozeadrese = System.IO.File.ReadAllLines("C:/Users/Dell/source/repos/ProiectTetris2/AdresePozelor.txt");
            if (Program.contActual != null)
            {
                nume.Text = "Buna, " + Program.contActual.username + "!";
                int codpoza = Program.contActual.pozaProfil;
                pictureBox1.Image = Image.FromFile(pozeadrese[codpoza]);
                BaniLB.Text = "Bani: " + Program.contActual.bani;
                XPLB.Text = "XP: " + Program.contActual.xp;
            }
            else
            {
                button1.Enabled = false;
                button5.Text = "Inapoi";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.contActual = null;
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScoruriTop form3 = new ScoruriTop("0");
            form3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nivel = 1;
            if (radioButton2.Checked == true) nivel = 2;
            else if (radioButton3.Checked == true) nivel = 3;
            var joc = new Jocul(nivel);
            joc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop sh = new Shop();
            this.Close();
            sh.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

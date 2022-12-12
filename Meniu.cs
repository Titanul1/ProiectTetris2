﻿using System;
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
            if (Program.contActual != null)
            {
                nume.Text = "Buna, " + Program.contActual.username + "!";
            }
            else button5.Text = "Inapoi";

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
    }
}
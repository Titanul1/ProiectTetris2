﻿using System;
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
    public partial class W : Form
    {
        public W()
        {
            InitializeComponent();
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Gata_Click(object sender, EventArgs e)
        {
            bool gasit = false;
            for (int i = 0; i < Program.listaConturi.conturi.Count; i++)
            {
                if (Program.listaConturi.conturi[i].username == userN.Text)
                {
                    MessageBox.Show("Utilizatorul deja exista.");
                    gasit = true;
                    break;
                }
            }
            if (pw1.Text != pw2.Text)
            {
                MessageBox.Show("Parole nu sunt la fel. Reintrodu-le.");
                pw1.Text = "";
                pw2.Text = "";
            }
            else if (pw1.Text == pw2.Text && gasit == false)
            {
                Program.Cont nouCont = new Program.Cont();
                nouCont.username = userN.Text;
                nouCont.parola = pw2.Text;
                nouCont.id = Program.listaConturi.conturi.Count + 1;
                Program.listaConturi.conturi.Add(nouCont);
                System.IO.File.WriteAllText("C:/Users/Dell/source/repos/ProiectTetris2/Conturi.txt", JsonSerializer.Serialize(Program.listaConturi));
                Program.Jucator nouJucator = new Program.Jucator();
                nouJucator.numePersonal = userN.Text;
                nouJucator.pozaProfil = 3;
                nouJucator.bani = 0;
                nouJucator.xp = 0;
                nouJucator.produseCumparate = new List<int>();
                nouJucator.produseCumparate.Add(3);
                MessageBox.Show("Contul a fost creat!");
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }

        }

        private void W_Load(object sender, EventArgs e)
        {

        }
    }
}

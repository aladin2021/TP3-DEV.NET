using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP3_DEV.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblsaisie_Click(object sender, EventArgs e)
        {

        }

        private void txt_saisie_TextChanged(object sender, EventArgs e)
        {
            if (txt_saisie.Text == "")
            {
                btn_Ajouter.Enabled = false;
            }
            else
            {
                btn_Ajouter.Enabled = true;
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txt_saisie.Text.Trim());
            txt_saisie.Clear();
            btnAll1to2.Enabled = true;
            btn1_effacertout.Enabled = true;
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn1_effacer.Enabled = true;
            btn1to2.Enabled = true;
        }

        private void btn1_effacer_Click(object sender, EventArgs e)
        {
            lst1.Items.Remove(lst1.SelectedItem);
            btn1_effacer.Enabled = false;
            btn1to2.Enabled = false;

            if (lst1.Items.Count == 0)
            {
                btn1_effacertout.Enabled = false;
                btnAll1to2.Enabled = false;
            }
        }

        private void btn1_effacertout_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            btnAll1to2.Enabled = false;
            btn1_effacertout.Enabled = false;
            btn1_effacer.Enabled = false;
            btn1to2.Enabled = false;
        }

        private void btn1to2_Click(object sender, EventArgs e)
        {
            lst2.Items.Add(lst1.SelectedItem);
            lst1.Items.Remove(lst1.SelectedItem);
            btn1to2.Enabled = false;
            btn1_effacer.Enabled = false;
            if (lst1.Items.Count == 0)
            {
                btn1_effacertout.Enabled = false;
                btnAll1to2.Enabled = false;
            }
            btnAll2to1.Enabled = true;
            btn2_effacertout.Enabled = true;
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn2_effacer.Enabled = true;
            btn2to1.Enabled = true;
        }

        private void btn2_effacer_Click(object sender, EventArgs e)
        {
            lst2.Items.Remove(lst2.SelectedItem);
            btn2_effacer.Enabled = false;
            btn2to1.Enabled = false;

            if (lst2.Items.Count == 0)
            {
                btn2_effacertout.Enabled = false;
                btnAll2to1.Enabled = false;
            }
        }

        private void btn2_effacertout_Click(object sender, EventArgs e)
        {
            lst2.Items.Clear();
            btnAll2to1.Enabled = false;
            btn2_effacertout.Enabled = false;
            btn2_effacer.Enabled = false;
            btn2to1.Enabled = false;
        }

        private void btnAll2to1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int nbr = lst2.Items.Count;
            for (i = 0; i < nbr; i++)
            {
                lst1.Items.Add(lst2.Items[(nbr - 1) - i]);
                lst2.Items.Remove(lst2.Items[(nbr - 1) - i]);
            }
        }

        private void btn2to1_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(lst2.SelectedItem);
            lst2.Items.Remove(lst2.SelectedItem);
            btn2to1.Enabled = false;
            btn2_effacer.Enabled = false;
            if (lst2.Items.Count == 0)
            {
                btn2_effacertout.Enabled = false;
                btnAll2to1.Enabled = false;
            }
            btnAll1to2.Enabled = true;
            btn1_effacertout.Enabled = true;
        }

        private void btnAll1to2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int nbr = lst1.Items.Count;
            for (i = 0; i < nbr; i++)
            {
                lst2.Items.Add(lst1.Items[(nbr - 1) - i]);
                lst1.Items.Remove(lst1.Items[(nbr - 1) - i]);
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

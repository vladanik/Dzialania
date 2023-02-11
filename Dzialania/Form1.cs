using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dzialania
{
    public partial class Form1 : Form
    {
        bool IsCtrlPressed = (Control.ModifierKeys & Keys.Control) != 0;

        int a;
        int b;
        int wynik;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void liczWszystko(object sender, EventArgs e)
        {
            //MessageBox.Show("zmiana!");

            try
            {
                a = Convert.ToInt32(tbPierwsza.Text, 10);
                b = Convert.ToInt32(tbDruga.Text, 10);
                if (rbDodaj.Checked)
                    wynik = a + b;
                else if (rbOdejmij.Checked)
                    wynik = a - b;
                else if (rbPomnoz.Checked)
                    wynik = a * b;
                else if (rbPodziel.Checked)
                    wynik = a / b;
            }
            catch (Exception)
            {
            
            }
        }

        private void tbDruga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(tbDruga.Text, 10);
            }
            catch (Exception)
            {

            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            /*try
            {
                lWynik.Text = "Wynik: " + (a / b);
            }
            catch (DivideByZeroException)
            {
                lWynik.Text = "Dzielenie przez zero!";
            }*/
        }

        private void rbDodaj_CheckedChanged(object sender, EventArgs e)
        {

            //lWynik.Text = "Wynik: " + (a + b);
        }

        private void rbOdejmij_CheckedChanged(object sender, EventArgs e)
        {
            //lWynik.Text = "Wynik: " + (a - b);
        }

        private void rbPomnoz_CheckedChanged(object sender, EventArgs e)
        {
            //lWynik.Text = "Wynik: " + (a * b);
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            lWynik.Text = "Wynik: " + wynik;
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            tbPierwsza.Clear();
            tbDruga.Clear();
            lWynik.Text = "Wynik: ?";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O) {
                btnOblicz_Click(this, e);
            }

        }
    }
}

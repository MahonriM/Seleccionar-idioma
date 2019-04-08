using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mensaje;
        private void chBingles_CheckedChanged(object sender, EventArgs e)
        {
            if (chBingles.Checked ==true)
            {
                mensaje = lb.Text = ("Ingles");
            }
            else
            {
                mensaje = lb.Text = ("");
            }
        }
       

        private void chBoxFrances_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxFrances.Checked ==true)
            {
                mensaje = lb.Text = ("Frances");
            }
            else
            {
                mensaje = lb.Text = ("");
            }
        }

        private void chBoxAleman_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAleman.Checked == true)
            {
                mensaje = lb.Text = ("Aleman");
            }
            else
            {
                mensaje = lb.Text = ("");
            }
                
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            if(chBingles.Checked==true&&chBoxAleman.Checked==true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Ingles y Aleman");
            }
            if (chBingles.Checked==true&&chBoxFrances.Checked==true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Ingles y Frances");
            }
            if (chBoxFrances.Checked == true && chBingles.Checked == true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Frances e Ingles");
            }
            if (chBoxFrances.Checked==true&&chBoxAleman.Checked==true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Frances y Aleman");
            }
            if (chBoxAleman.Checked==true&&chBingles.Checked==true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Aleman e Ingles");
            }
            if (chBoxAleman.Checked==true&&chBoxFrances.Checked==true)
            {
                MessageBox.Show("Usted a seleccioado los idiomas Aleman y Frances");
            }
            if (chBingles.Checked==true&&chBoxFrances.Checked==true&&chBoxAleman.Checked==true)
            {
                MessageBox.Show("Usted a seleccionado los idiomas Ingles, Aleman y Frances");
            }
        }   
    }
}

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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            boton1.Enabled = false;
        }

        private void nombre1_TextChanged(object sender, EventArgs e)
        {
            controlboton();
        }

        private void controlboton()
        {
            if (nombre1.Text.Trim() != String.Empty && nombre1.Text.All(Char.IsLetter))
            {
                boton1.Enabled =true;
                errorProvider1.SetError(nombre1, "");
            }
            else
            {
                if (!(nombre1.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre1,"nombre solo letras");
                }
                else
                {
                    errorProvider1.SetError(nombre1, "sin nombre");
                }
                boton1.Enabled=false;
                nombre1.Focus();    
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            using (Form2 ventana = new Form2(nombre1.Text))
                ventana.ShowDialog();
        }
    }
}

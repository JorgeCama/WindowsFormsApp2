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
    public partial class Form2 : Form
    {
        string nombre_cliente;
        public Form2(string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mydbDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.Fill(this.mydbDataSet.EMPLEADOS);
        }

        private void C2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

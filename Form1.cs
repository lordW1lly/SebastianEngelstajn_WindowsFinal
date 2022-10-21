using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SebastianEngelstajn_WindowsFinal
{
    public partial class Form1 : Form
    {
        string Nombre;
        string Apellido;
        decimal Sueldo;
        string Puesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnValidaciones_Click(object sender, EventArgs e)
        {
            Sueldo = Convert.ToDecimal(txtSueldo.Text);
            Puesto = txtPuesto.Text;
            if(Sueldo <= 0)
            {
                MessageBox.Show("El sueldo debe ser mayor a 0");
            } else if(Puesto != "Soporte Tecnico" && Puesto != "DBA" && Puesto != "Desarrollador")
            {
                 MessageBox.Show("No es un puesto Valido");
            }
        }

        private void bttnMostrar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Puesto = txtPuesto.Text;
            MessageBox.Show(Nombre.ToUpper() +" ,"+ Puesto.ToUpper());
        }



    }
}

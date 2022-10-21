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

        private void bttnIngresarHoras_Click(object sender, EventArgs e)
        {
            int[] horasTrabajadas;
            int horasTotales = 0;
            horasTrabajadas = new int[5];
            for(int i = 0; i < horasTrabajadas.Length; i++)
            {
                int hora = Convert.ToInt32(Interaction.InputBox("ingrese horas trabajadas por dia"));
                horasTrabajadas[i] = hora;
                horasTotales = horasTotales + hora;
            }

            MessageBox.Show("El total de horas trabajadas en la semana fue: "+" "+horasTotales.ToString()+" horas");

            if(horasTotales < 20)
            {
                MessageBox.Show("No tiene dias libre en la semana que viene");
            } else if(horasTotales >= 20 && horasTotales < 30)
            {
                MessageBox.Show("Tiene un dia libre en la proxima semana");

            } else if( horasTotales > 30)
            {
                MessageBox.Show("Tiene dos dias libres la proxima semana");
            }

        }
    }
}

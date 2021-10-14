using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPOOClinica.Models;

namespace WindowsPOOClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarClick_Click(object sender, EventArgs e)
        {            
            Enfermero enfermero2 = new Enfermero("Ponzio","Leonardo",Convert.ToDateTime("09/12/1985"),"Av. Libertador 1205");

            MessageBox.Show(enfermero2.Apellido + " " + enfermero2.Nombre + " " + enfermero2.FechaNacimiento.ToShortDateString().ToString() + " Domicilio: " + enfermero2.Domicilio);

            Paciente paciente2 = new Paciente("Auzqui","Micaela",Convert.ToDateTime("25/03/1997"),"Colon 1340",233);

            MessageBox.Show(paciente2.Apellido + " " + paciente2.Nombre + " " + paciente2.FechaNacimiento.ToShortDateString().ToString() + " Domicilio: " + paciente2.Domicilio + " " + "Historia clinica N: " + paciente2.NroHistoriaClinica);


            Director director2 = new Director( "Quarta", "Federico",Convert.ToDateTime("05/09/1998"),"Gascon 2190") ;

            MessageBox.Show(director2.Apellido + " " + director2.Nombre + " " + director2.FechaNacimiento.ToShortDateString().ToString() + " Domicilio: " + director2.Domicilio);

            Clinica clinica = new Clinica("Clinica pueyrredon", "Santiado del estero 2100");

            MessageBox.Show(clinica.Nombre + " " + clinica.Domicilio);

            Enfermero enfermero;

            enfermero = new Enfermero();

            enfermero.ID = 1;
            enfermero.Apellido = "Perez";
            enfermero.Nombre = "Nicolas";
            enfermero.FechaNacimiento = Convert.ToDateTime("13/12/1990");
            enfermero.Domicilio = "San Salvador 7043";

            Paciente paciente = new Paciente() { ID = 1, Apellido = "Palacios", Nombre = "Agustina", FechaNacimiento = Convert.ToDateTime("29/10/2000"), Domicilio = "Falucho 2030", NroHistoriaClinica = 230 };

            Director director = new Director() { ID = 344, Apellido = "Neme", Nombre = " Alejandro", FechaNacimiento = Convert.ToDateTime("05/09/1998"), Domicilio = "Las heras 3026" };

            MessageBox.Show("ID " + paciente.ID + " " + paciente.Apellido + " " + paciente.Nombre + " " + paciente.FechaNacimiento + " Domicilio: " + paciente.Domicilio + " " + "Historia clinica N: " + paciente.NroHistoriaClinica);

            MessageBox.Show("ID " + enfermero.ID + " " + enfermero.Apellido + " " + enfermero.Nombre + " " + enfermero.FechaNacimiento.ToShortDateString().ToString() + " Domicilio: " + enfermero.Domicilio);

            MessageBox.Show("ID " + director.ID + " " + director.Apellido + " " + director.Nombre + " " + director.FechaNacimiento.ToShortDateString().ToString() + " Domicilio: " + director.Domicilio);


        }
    }
}

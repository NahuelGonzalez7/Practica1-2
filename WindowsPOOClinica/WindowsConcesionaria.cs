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
    public partial class WindowsConcesionaria : Form
    {
        public WindowsConcesionaria()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta("BMW","X5","Negro",5,"AAA 777",2008);
            MessageBox.Show("CAMIONETA: " + camioneta.Marca + " " + camioneta.Modelo + " " + camioneta.Color + " " + camioneta.CantidadDePuertas + " " + camioneta.Matricula + " " + camioneta.Anio);

            Auto auto = new Auto("Audi", "A5", "Blanco" , 5, "JXZ 269" , 2017);
            MessageBox.Show("AUTO: " + auto.Marca + " " + auto.Modelo + " " + auto.Color + " " + auto.CantidadDePuertas + " " + auto.Matricula + " " + auto.Anio);

            Moto moto = new Moto("Kawasaki", "Ninja", "Amarilla", "GPZ 927", 2011);
            MessageBox.Show("MOTO: "+ moto.Marca + " " + moto.Modelo + " " + moto.Color + " " + moto.Matricula + " " + moto.Anio);

            Camioneta camioneta2 = new Camioneta("Audi", "Q5", "Roja", 5, "NMO 663", 2018);
            MessageBox.Show("CAMIONETA 2: " + camioneta2.Marca + " " + camioneta2.Modelo + " " + camioneta2.Color + " " + camioneta2.CantidadDePuertas + " " + camioneta2.Matricula + " " + camioneta2.Anio);


            Auto auto2 = new Auto("Ford", "Escort XLR", "Plateado", 3, "AFE 998", 1998);
            MessageBox.Show("AUTO 2:" + " " + auto2.Marca + " " + auto2.Modelo + " " + auto2.Color + " " + auto2.CantidadDePuertas + " " + auto2.Matricula + " " + auto2.Anio);

            Moto moto2 = new Moto("Honda", "Tornado", "Verde Lima", "FGH 573", 2009);
            MessageBox.Show("MOTO 2: " + moto2.Marca + " " + moto2.Modelo + " " + moto2.Color + " " + moto2.Matricula + " " + moto2.Anio);
        }
    }
}

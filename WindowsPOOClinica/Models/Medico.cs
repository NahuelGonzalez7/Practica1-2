using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{

    //default es private

    public class Medico
    {
        #region Constructores

        public Medico() { }

        public Medico(string Nombre,string Apellido, string Matricula) 
        {
            //Inicializamos las propiedades

            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Matricula = Matricula;
        }



        #endregion




        #region propiedades autoimplementadas

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }

        #endregion
    }



}

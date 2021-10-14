using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    public class Clinica
    {
        #region constructores

        public Clinica(string nombre, string domicilio)
        {
            Nombre = nombre;
            Domicilio = domicilio;
        }

        #endregion



        #region propiedades 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    public class Moto
    {
        #region constructores
        public Moto(string marca, string modelo, string color, string matricula,int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Matricula = matricula;
            Anio = anio;
        }
        #endregion

        #region propiedades autoimplementadas

        public string Marca
        {
            get; set;
        }
        public string Modelo
        {
            get; set;
        }
        public string Color
        {
            get; set;
        }
        public string Matricula
        {
            get; set;
        }
        public int Anio
        {
            get; set;
        }
        #endregion
    }
}

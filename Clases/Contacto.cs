using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prueba_Maui.Clases
{
    public class Contacto
    {
        private string _nombre;
        private string _apellido;
        private long _numeroTelefonico;
        public Contacto()
        {
            _nombre = "Sin Nombre";
            _apellido = "Sin Apellido";
            _numeroTelefonico = 0;
        }
        public Contacto(string nombre, string apellido, long numeroTelefonico)
        {
            _nombre = nombre;
            _apellido = apellido;
            _numeroTelefonico = numeroTelefonico;
        }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public long NumeroTelefonico { get { return _numeroTelefonico; } set { _numeroTelefonico = value; } }
    }
}
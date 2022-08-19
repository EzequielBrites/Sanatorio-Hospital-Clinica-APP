using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio_Hospital_Clinica_APP
{
    internal class Parametro
    {
        private string nombre;
        private Object valor;

        public string pNombre { set { nombre = value; } get { return nombre; } }
        public Object pValor { set { valor = value; }get { return valor; } }
        public Parametro(string nombre, Object valor)
        {
            this.nombre = nombre;
            this.valor = valor;

        }
    }
}

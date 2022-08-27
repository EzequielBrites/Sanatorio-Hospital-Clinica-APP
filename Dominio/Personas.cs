using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio_Hospital_Clinica_APP
{
    internal abstract class Personas
    {
        private string nombre, apellido, domicilio, eMail;
        private int dni, edad, estadoCivil, sexo;
        private long celular;
        private DateTime fechaNacimiento;

        public string Nombre { set { nombre = value; } get { return nombre; } }
        public string Apellido { set { apellido = value; } get { return apellido; } }
        public string Domicilio { set { domicilio = value; } get { return domicilio; } }
        public string EMail { set { eMail = value; } get { return eMail; } }
        public int Dni { set { dni = value; } get { return dni; } }
        public long Celular { set { celular = value; } get { return celular; } }
        public int Edad { set { edad = value; } get { return edad; } }
        public int EstadoCivil { set { estadoCivil = value; } get { return estadoCivil; } }
        public DateTime FechaNacimiento { set { fechaNacimiento = value; }get { return fechaNacimiento; } }
        public int Sexo { set { sexo = value; } get { return sexo; } }

        public Personas()
        {
            sexo = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            domicilio = string.Empty;
            eMail = string.Empty;
            dni = 0;
            celular = 0;
            edad = 0;
            estadoCivil = 0;
            fechaNacimiento = DateTime.Today;
        }
        public Personas(int sexo, string nombre, string apellido, string domicilio, string eMail, int dni, long celular, int edad, int estadoCivil, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.eMail = eMail;
            this.dni = dni;
            this.celular = celular;
            this.edad = edad;
            this.estadoCivil = estadoCivil;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return nombre+apellido;
        }
    }
}

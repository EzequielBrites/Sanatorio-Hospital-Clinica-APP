using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio_Hospital_Clinica_APP
{
    internal class Medicos : Personas
    {
        private int nroMatricula, especialidad;

        public int NroMatricula { set { nroMatricula = value; } get { return nroMatricula; } }
        public int Especialidad { set { especialidad = value; } get { return especialidad; } }

        public Medicos() : base()
        {
            nroMatricula = 0;
            especialidad = 0;
        }

        public Medicos(int nroMatricula, int especialidad,int sexo, string nombre, string apellido, string domicilio, string eMail, int dni, int celular, int edad, int estadoCivil, DateTime fechaNacimiento) : base
            (sexo,nombre, apellido, domicilio, eMail, dni, celular, edad, estadoCivil, fechaNacimiento)
        {
            this.nroMatricula = nroMatricula;
            this.especialidad = especialidad;
        }
        public override string ToString()
        {
            return base.ToString() + nroMatricula + especialidad;
        }


    }
}

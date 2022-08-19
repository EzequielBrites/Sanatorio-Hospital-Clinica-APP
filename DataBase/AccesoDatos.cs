using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sanatorio_Hospital_Clinica_APP
{
    internal class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        string cadenaConexion;

        public AccesoDatos()
        {
            cadenaConexion = @"Data Source = localhost; Initial Catalog = sanatorio; Integrated Security = True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultarBD(string sp)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = sp;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public int actualizarBD(string sp, List<Parametro> lparametros)
        {
            int filasAfectadas = 0;
            conectar();
            comando.CommandText = sp;
            foreach (Parametro p in lparametros)
            {
                comando.Parameters.AddWithValue(p.pNombre, p.pValor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }





    }
}

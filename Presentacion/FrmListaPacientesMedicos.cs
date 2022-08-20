using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanatorio_Hospital_Clinica_APP.Presentacion
{
    public partial class FrmListaPacientesMedicos : Form
    {
        List<Medicos> lmedicos;
        List<Pacientes> lpacientes;
        AccesoDatos oBD;
        public FrmListaPacientesMedicos()
        {
            InitializeComponent();
            lmedicos = new List<Medicos>();
            lpacientes = new List<Pacientes>();
            oBD = new AccesoDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void cargarGrilla(string sp)
        {
            Pacientes p = new Pacientes();
            lpacientes.Clear();
            lmedicos.Clear();
            DataTable tabla = new DataTable();
            tabla = oBD.consultarBD(sp);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvPacientesMedicos.Rows.Add(tabla.Rows[i]["cod_paciente"], tabla.Rows[i]["Apellido"], tabla.Rows[i]["Nombre"]
                    , tabla.Rows[i]["Domicilio"], tabla.Rows[i]["Fecha_Nacimiento"], tabla.Rows[i]["celular"]);
            }

        }
        private void FrmListaPacientesMedicos_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelarList.Enabled = false;
            btnCerrar.Enabled = true;

          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(cbMedicos.Checked==true)
            {
                cargarGrilla("sp_consultar_medicos");
            }
            else
            {
                cargarGrilla("sp_consultar_pacientes");
            }
        }

        private void cbPacientes_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPacientes.Checked== true)
            {
                cbMedicos.Checked = false;
                
            }
            btnActualizar.Enabled = true;
            
          
        }

        private void cbMedicos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMedicos.Checked == true)
            {
                cbPacientes.Checked = false;
                
            }
            btnActualizar.Enabled = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
                this.Close();
        }
    }
}

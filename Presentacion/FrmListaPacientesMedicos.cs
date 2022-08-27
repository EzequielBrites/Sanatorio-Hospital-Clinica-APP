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
        List<Pacientes> lAfiliados;
        AccesoDatos oBD;
        public FrmListaPacientesMedicos()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            lAfiliados = new List<Pacientes>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void cargarGrilla(string sp)
        {
            Pacientes p = new Pacientes();
            lAfiliados.Clear();
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
            btnSeleccionar.Enabled = false;
            btnCancelar.Enabled = true;
            cargarGrilla("sp_consultar_pacientes");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cancelar?","Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}

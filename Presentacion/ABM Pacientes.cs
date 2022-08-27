using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanatorio_Hospital_Clinica_APP.Presentacion;

namespace Sanatorio_Hospital_Clinica_APP
{
    public partial class frmConsultasMedicas : Form
    {
        AccesoDatos oBD;
        List<Parametro> lparametros;
        public frmConsultasMedicas()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            lparametros = new List<Parametro>();
        }

        private void frmConsultasMedicas_Load(object sender, EventArgs e)
        {
            cargarCombos(cboEstadoCivil,"sp_consultar_estado_civil");
            txtNumeroPaciente.Enabled = false;
            habilitar(false);

        }
        public void habilitar(bool x)
        {
            txtApellidoPaciente.Enabled = x;
            txtBarrio.Enabled = x;
            txtDni.Enabled = x;
            txtDomicilio.Enabled = x;
            txtEdadPaciente.Enabled = x;
            txtNombrePaciente.Enabled = x;
            txtNumeroCelular.Enabled = x;
            txtEmail.Enabled = x;
            cboEstadoCivil.Enabled = x;
            btnBorrar.Enabled = x;
            btnCancelar.Enabled = x;
            btnSalir.Enabled = !x;
            btnGuardar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;

        }
        public void cargarCombos(ComboBox combo, string sp)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultarBD(sp);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir", "salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lparametros.Clear();
            Pacientes p = new Pacientes();
            p.Apellido = txtApellidoPaciente.Text;
            p.Nombre = txtNombrePaciente.Text;
            if (rbtFemenino.Checked == true)
                p.Sexo = 1;
            else
                p.Sexo = 2;
            //p.Celular = Convert.ToInt64(txtNumeroCelular.Text);
            p.Dni = Convert.ToInt32(txtDni.Text);
            p.Domicilio = txtDomicilio.Text;
            p.EMail = txtEmail.Text;
            p.EstadoCivil = cboEstadoCivil.SelectedIndex;
            p.FechaNacimiento = dtpFechaNacimiento.Value;

            lparametros.Add(new Parametro("@apellido", p.Apellido));
            lparametros.Add(new Parametro("@nombre", p.Nombre));
            lparametros.Add(new Parametro("@domicilio", p.Domicilio));
            lparametros.Add(new Parametro("@celular", p.Celular));
            lparametros.Add(new Parametro("@e_mail", p.EMail));
            lparametros.Add(new Parametro("@edad", p.Edad));
            lparametros.Add(new Parametro("@estado_civil", p.EstadoCivil));
            lparametros.Add(new Parametro("@fecha_nacimiento", p.FechaNacimiento));
            lparametros.Add(new Parametro("@dni", p.Dni));
            lparametros.Add(new Parametro("@obrasocial", p.ObraSocial));
            lparametros.Add(new Parametro("@sexo", p.Sexo));
            if(oBD.actualizarBD("sp_insertar_paciente", lparametros)>0)

            {
                MessageBox.Show("Se ingreso con exito el paciente");
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmListaPacientesMedicos frmpm = new FrmListaPacientesMedicos();
            frmpm.ShowDialog();
            frmpm.Dispose();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}

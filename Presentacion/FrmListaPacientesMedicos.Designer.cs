namespace Sanatorio_Hospital_Clinica_APP.Presentacion
{
    partial class FrmListaPacientesMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPacientesMedicos = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(672, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dgvPacientesMedicos
            // 
            this.dgvPacientesMedicos.AllowUserToAddRows = false;
            this.dgvPacientesMedicos.AllowUserToDeleteRows = false;
            this.dgvPacientesMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNombre,
            this.ColApellido,
            this.ColDomicilio,
            this.ColFechaNacimiento,
            this.ColCelular});
            this.dgvPacientesMedicos.Location = new System.Drawing.Point(32, 67);
            this.dgvPacientesMedicos.Name = "dgvPacientesMedicos";
            this.dgvPacientesMedicos.ReadOnly = true;
            this.dgvPacientesMedicos.Size = new System.Drawing.Size(734, 314);
            this.dgvPacientesMedicos.TabIndex = 2;
            this.dgvPacientesMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id ";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 80;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            // 
            // ColDomicilio
            // 
            this.ColDomicilio.HeaderText = "Domicilio";
            this.ColDomicilio.Name = "ColDomicilio";
            this.ColDomicilio.ReadOnly = true;
            this.ColDomicilio.Width = 150;
            // 
            // ColFechaNacimiento
            // 
            this.ColFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.ColFechaNacimiento.Name = "ColFechaNacimiento";
            this.ColFechaNacimiento.ReadOnly = true;
            this.ColFechaNacimiento.Width = 130;
            // 
            // ColCelular
            // 
            this.ColCelular.HeaderText = "Telefono";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            this.ColCelular.Width = 130;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(528, 425);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(94, 36);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione cual desea editar";
            // 
            // FrmListaPacientesMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvPacientesMedicos);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmListaPacientesMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Medicos/Pacientes";
            this.Load += new System.EventHandler(this.FrmListaPacientesMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPacientesMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelarList = new System.Windows.Forms.Button();
            this.dgvPacientesMedicos = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbMedicos = new System.Windows.Forms.CheckBox();
            this.cbPacientes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(171, 423);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarList
            // 
            this.btnCancelarList.Location = new System.Drawing.Point(312, 423);
            this.btnCancelarList.Name = "btnCancelarList";
            this.btnCancelarList.Size = new System.Drawing.Size(94, 36);
            this.btnCancelarList.TabIndex = 1;
            this.btnCancelarList.Text = "Cancelar";
            this.btnCancelarList.UseVisualStyleBackColor = true;
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
            this.dgvPacientesMedicos.Location = new System.Drawing.Point(32, 99);
            this.dgvPacientesMedicos.Name = "dgvPacientesMedicos";
            this.dgvPacientesMedicos.ReadOnly = true;
            this.dgvPacientesMedicos.Size = new System.Drawing.Size(734, 306);
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
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(33, 423);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 36);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbMedicos
            // 
            this.cbMedicos.AutoSize = true;
            this.cbMedicos.Location = new System.Drawing.Point(32, 58);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(66, 17);
            this.cbMedicos.TabIndex = 4;
            this.cbMedicos.Text = "Medicos";
            this.cbMedicos.UseVisualStyleBackColor = true;
            this.cbMedicos.CheckedChanged += new System.EventHandler(this.cbMedicos_CheckedChanged);
            // 
            // cbPacientes
            // 
            this.cbPacientes.AutoSize = true;
            this.cbPacientes.Location = new System.Drawing.Point(125, 58);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(73, 17);
            this.cbPacientes.TabIndex = 5;
            this.cbPacientes.Text = "Pacientes";
            this.cbPacientes.UseVisualStyleBackColor = true;
            this.cbPacientes.CheckedChanged += new System.EventHandler(this.cbPacientes_CheckedChanged);
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
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(672, 425);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 36);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListaPacientesMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPacientesMedicos);
            this.Controls.Add(this.btnCancelarList);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmListaPacientesMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Medicos/Pacientes";
            this.Load += new System.EventHandler(this.FrmListaPacientesMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelarList;
        private System.Windows.Forms.DataGridView dgvPacientesMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox cbMedicos;
        private System.Windows.Forms.CheckBox cbPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
namespace SistemaAtencionAlPublico.Formularios_principales
{
    partial class FrmGerente
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbl_opcion = new System.Windows.Forms.Label();
            this.lbl_adminInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(402, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 15);
            this.lblUsuario.TabIndex = 5;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 9);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 15);
            this.lblIngreso.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(12, 663);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(213, 273);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(143, 37);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Eliminar cliente";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 37);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(213, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar clientes";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(213, 402);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(143, 37);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar clientes";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(213, 316);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 37);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar cliente";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbl_opcion
            // 
            this.lbl_opcion.AutoSize = true;
            this.lbl_opcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_opcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_opcion.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_opcion.Location = new System.Drawing.Point(169, 164);
            this.lbl_opcion.Name = "lbl_opcion";
            this.lbl_opcion.Size = new System.Drawing.Size(229, 21);
            this.lbl_opcion.TabIndex = 16;
            this.lbl_opcion.Text = "Seleccione lo que desea realizar";
            // 
            // lbl_adminInicio
            // 
            this.lbl_adminInicio.AutoSize = true;
            this.lbl_adminInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adminInicio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_adminInicio.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_adminInicio.Location = new System.Drawing.Point(199, 127);
            this.lbl_adminInicio.Name = "lbl_adminInicio";
            this.lbl_adminInicio.Size = new System.Drawing.Size(170, 37);
            this.lbl_adminInicio.TabIndex = 15;
            this.lbl_adminInicio.Text = "BIENVENIDO";
            // 
            // FrmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 711);
            this.Controls.Add(this.lbl_opcion);
            this.Controls.Add(this.lbl_adminInicio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIngreso);
            this.Name = "FrmGerente";
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.FrmGerente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblUsuario;
        private Label lblIngreso;
        private Button btnSalir;
        private Button btnBaja;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnCargar;
        private Button btnModificar;
        private Label lbl_opcion;
        private Label lbl_adminInicio;
    }
}
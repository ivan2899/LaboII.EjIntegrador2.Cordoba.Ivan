namespace SistemaAtencionAlPublico.Formularios_principales
{
    partial class FrmCliente
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_opcion = new System.Windows.Forms.Label();
            this.lbl_adminInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(12, 663);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular plazo fijo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 9);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 15);
            this.lblIngreso.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(412, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 15);
            this.lblUsuario.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Avanzar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pedir prestamo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Avanzar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbl_opcion
            // 
            this.lbl_opcion.AutoSize = true;
            this.lbl_opcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_opcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_opcion.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_opcion.Location = new System.Drawing.Point(181, 185);
            this.lbl_opcion.Name = "lbl_opcion";
            this.lbl_opcion.Size = new System.Drawing.Size(229, 21);
            this.lbl_opcion.TabIndex = 18;
            this.lbl_opcion.Text = "Seleccione lo que desea realizar";
            // 
            // lbl_adminInicio
            // 
            this.lbl_adminInicio.AutoSize = true;
            this.lbl_adminInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adminInicio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_adminInicio.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_adminInicio.Location = new System.Drawing.Point(211, 148);
            this.lbl_adminInicio.Name = "lbl_adminInicio";
            this.lbl_adminInicio.Size = new System.Drawing.Size(170, 37);
            this.lbl_adminInicio.TabIndex = 17;
            this.lbl_adminInicio.Text = "BIENVENIDO";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 711);
            this.Controls.Add(this.lbl_opcion);
            this.Controls.Add(this.lbl_adminInicio);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private Button button2;
        private Label lblIngreso;
        private Label lblUsuario;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label lbl_opcion;
        private Label lbl_adminInicio;
    }
}
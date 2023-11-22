namespace SistemaAtencionAlPublico
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.chkClave = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxCompletar = new System.Windows.Forms.ComboBox();
            this.lblCompletar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Salmon;
            this.btnAcceder.Location = new System.Drawing.Point(221, 393);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(161, 50);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(175, 71);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(249, 46);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio de sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(186, 174);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(160, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Ingrese su usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(186, 255);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(141, 25);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Ingrese su clave:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(186, 202);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 31);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.Location = new System.Drawing.Point(186, 283);
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceholderText = "Clave";
            this.txtClave.Size = new System.Drawing.Size(238, 31);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // btnCompletar
            // 
            this.btnCompletar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCompletar.Location = new System.Drawing.Point(24, 625);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(106, 30);
            this.btnCompletar.TabIndex = 6;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = false;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // chkClave
            // 
            this.chkClave.AutoSize = true;
            this.chkClave.BackColor = System.Drawing.Color.Transparent;
            this.chkClave.ForeColor = System.Drawing.Color.White;
            this.chkClave.Location = new System.Drawing.Point(186, 320);
            this.chkClave.Name = "chkClave";
            this.chkClave.Size = new System.Drawing.Size(97, 19);
            this.chkClave.TabIndex = 7;
            this.chkClave.Text = "Mostrar clave";
            this.chkClave.UseVisualStyleBackColor = false;
            this.chkClave.CheckedChanged += new System.EventHandler(this.chkClave_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCerrar.Location = new System.Drawing.Point(469, 625);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 30);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLimpiar.Location = new System.Drawing.Point(221, 625);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 30);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxCompletar
            // 
            this.cbxCompletar.FormattingEnabled = true;
            this.cbxCompletar.Location = new System.Drawing.Point(24, 582);
            this.cbxCompletar.Name = "cbxCompletar";
            this.cbxCompletar.Size = new System.Drawing.Size(106, 23);
            this.cbxCompletar.TabIndex = 10;
            // 
            // lblCompletar
            // 
            this.lblCompletar.AutoSize = true;
            this.lblCompletar.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompletar.ForeColor = System.Drawing.Color.White;
            this.lblCompletar.Location = new System.Drawing.Point(21, 542);
            this.lblCompletar.Name = "lblCompletar";
            this.lblCompletar.Size = new System.Drawing.Size(109, 20);
            this.lblCompletar.TabIndex = 11;
            this.lblCompletar.Text = "Autocompletar";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 672);
            this.Controls.Add(this.lblCompletar);
            this.Controls.Add(this.cbxCompletar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.chkClave);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.btnAcceder);
            this.Name = "FrmLogin";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAcceder;
        private Label lblInicio;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnCompletar;
        private CheckBox chkClave;
        private Button btnCerrar;
        private Button btnLimpiar;
        private ComboBox cbxCompletar;
        private Label lblCompletar;
    }
}
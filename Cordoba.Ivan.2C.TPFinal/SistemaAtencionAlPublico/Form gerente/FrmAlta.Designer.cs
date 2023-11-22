namespace SistemaAtencionAlPublico.Form_gerente
{
    partial class FrmAlta
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbxEleccionUsuario = new System.Windows.Forms.ComboBox();
            this.lbl_eleccionUsuario = new System.Windows.Forms.Label();
            this.lbl_alta = new System.Windows.Forms.Label();
            this.btn_fin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(42, 452);
            this.txt_id.Name = "txt_id";
            this.txt_id.PlaceholderText = "Ingrese ID";
            this.txt_id.Size = new System.Drawing.Size(201, 27);
            this.txt_id.TabIndex = 50;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(42, 428);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(179, 21);
            this.lbl_id.TabIndex = 49;
            this.lbl_id.Text = "Indique el id del usuario:";
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clave.Location = new System.Drawing.Point(42, 391);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PlaceholderText = "Ingrese clave";
            this.txt_clave.Size = new System.Drawing.Size(201, 27);
            this.txt_clave.TabIndex = 48;
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clave.ForeColor = System.Drawing.Color.White;
            this.lbl_clave.Location = new System.Drawing.Point(42, 367);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(201, 21);
            this.lbl_clave.TabIndex = 47;
            this.lbl_clave.Text = "Indique la clave del usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(42, 321);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Ingrese usuario";
            this.txt_usuario.Size = new System.Drawing.Size(201, 27);
            this.txt_usuario.TabIndex = 46;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(42, 297);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(194, 21);
            this.lbl_usuario.TabIndex = 45;
            this.lbl_usuario.Text = "Coloque el usuario a crear:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_apellido.Location = new System.Drawing.Point(42, 250);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "Ingrese apellido";
            this.txt_apellido.Size = new System.Drawing.Size(201, 27);
            this.txt_apellido.TabIndex = 44;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(42, 226);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(167, 21);
            this.lbl_apellido.TabIndex = 43;
            this.lbl_apellido.Text = "Apellido de la persona:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(42, 180);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Ingrese nombre";
            this.txt_nombre.Size = new System.Drawing.Size(201, 27);
            this.txt_nombre.TabIndex = 42;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(42, 156);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(168, 21);
            this.lbl_nombre.TabIndex = 41;
            this.lbl_nombre.Text = "Nombre de la persona:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(361, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 91);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbxEleccionUsuario
            // 
            this.cbxEleccionUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxEleccionUsuario.FormattingEnabled = true;
            this.cbxEleccionUsuario.IntegralHeight = false;
            this.cbxEleccionUsuario.Items.AddRange(new object[] {
            "Gerente",
            "Cliente"});
            this.cbxEleccionUsuario.Location = new System.Drawing.Point(42, 125);
            this.cbxEleccionUsuario.Name = "cbxEleccionUsuario";
            this.cbxEleccionUsuario.Size = new System.Drawing.Size(201, 28);
            this.cbxEleccionUsuario.TabIndex = 39;
            this.cbxEleccionUsuario.TabStop = false;
            // 
            // lbl_eleccionUsuario
            // 
            this.lbl_eleccionUsuario.AutoSize = true;
            this.lbl_eleccionUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eleccionUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_eleccionUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_eleccionUsuario.Location = new System.Drawing.Point(42, 101);
            this.lbl_eleccionUsuario.Name = "lbl_eleccionUsuario";
            this.lbl_eleccionUsuario.Size = new System.Drawing.Size(275, 21);
            this.lbl_eleccionUsuario.TabIndex = 38;
            this.lbl_eleccionUsuario.Text = "Que tipo de usuario desea dar de alta?";
            // 
            // lbl_alta
            // 
            this.lbl_alta.AutoSize = true;
            this.lbl_alta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_alta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_alta.Location = new System.Drawing.Point(293, 24);
            this.lbl_alta.Name = "lbl_alta";
            this.lbl_alta.Size = new System.Drawing.Size(158, 37);
            this.lbl_alta.TabIndex = 37;
            this.lbl_alta.Text = "Alta usuario";
            // 
            // btn_fin
            // 
            this.btn_fin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_fin.ForeColor = System.Drawing.Color.White;
            this.btn_fin.Location = new System.Drawing.Point(35, 551);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(201, 36);
            this.btn_fin.TabIndex = 51;
            this.btn_fin.Text = "Finalizar";
            this.btn_fin.UseVisualStyleBackColor = false;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(684, 632);
            this.Controls.Add(this.btn_fin);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxEleccionUsuario);
            this.Controls.Add(this.lbl_eleccionUsuario);
            this.Controls.Add(this.lbl_alta);
            this.Name = "FrmAlta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_id;
        private Label lbl_id;
        private TextBox txt_clave;
        private Label lbl_clave;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private TextBox txt_apellido;
        private Label lbl_apellido;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private Button btnSalir;
        private ComboBox cbxEleccionUsuario;
        private Label lbl_eleccionUsuario;
        private Label lbl_alta;
        private Button btn_fin;
    }
}
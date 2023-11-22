using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtencionAlPublico.Formularios_principales
{
    public partial class FrmCliente : Form
    {
        private string usuario;

        public FrmCliente(string usuario)
        {
            this.usuario = usuario;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = $"Ingreso: \n{DateTime.Now}";
            lblUsuario.Text = $"Usuario - CLIENTE \n{usuario}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.frmLogin.Show();
        }        
    }
}

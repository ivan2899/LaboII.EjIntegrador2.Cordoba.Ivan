using SistemaAtencionAlPublico.Form_gerente;
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
    public partial class FrmGerente : Form
    {
        private string usuario;

        public FrmGerente(string usuario)
        {
            this.usuario = usuario;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            InitializeComponent();
        }

        private void FrmGerente_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = $"Ingreso: \n{DateTime.Now}";
            lblUsuario.Text = $"Usuario - GERENTE \n{usuario}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.frmLogin.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlta formAlta = new FrmAlta();
            formAlta.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FrmBaja formBaja = new FrmBaja();
            formBaja.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificar formModificar = new FrmModificar();
            formModificar.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmGuardar formGuardar = new FrmGuardar();
            formGuardar.ShowDialog();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FrmCargar formCargar = new FrmCargar();
            formCargar.ShowDialog();
        }
    }
}

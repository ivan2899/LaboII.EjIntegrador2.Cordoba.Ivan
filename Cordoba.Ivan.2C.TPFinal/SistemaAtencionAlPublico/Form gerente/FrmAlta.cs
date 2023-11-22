using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Enumerados;

namespace SistemaAtencionAlPublico.Form_gerente
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cbxEleccionUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Entidades.Enumerados;
using SistemaAtencionAlPublico.Formularios_principales;

namespace SistemaAtencionAlPublico
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxCompletar.DataSource = Enum.GetValues(typeof(EClaseUsuario));

            cbxCompletar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Julio")
            {
                FrmCliente formCliente = new FrmCliente(txtUsuario.Text);
                Program.frmLogin.Hide();
                formCliente.Show();
            }
            else if (txtUsuario.Text == "Hola")
            {
                FrmGerente formGerente = new FrmGerente(txtUsuario.Text);
                Program.frmLogin.Hide();
                formGerente.Show();
            }
            else
            {
                MessageBox.Show("Complete los campos de usuario y clave, por favor", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLimpiar_Click(sender, e);
            }

        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            string op = cbxCompletar.Text;
            string auxUser;
            string auxPass;

            if (op == (EClaseUsuario.Gerente).ToString())
            {
                auxUser = "Hola";
                auxPass = "Chau";
            }
            else if (op == (EClaseUsuario.Cliente).ToString())
            {
                auxUser = "Julio";
                auxPass = "Chau";
            }
            else
            {
                auxUser = "Cesar";
                auxPass = "Chau";
            }

            this.txtUsuario.Text = auxUser;
            this.txtClave.Text = auxPass;
        }

        private void chkClave_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !txtClave.UseSystemPasswordChar;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msjCierre;
            msjCierre = MessageBox.Show("Desea cerrar la app?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msjCierre == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = String.Empty;
            this.txtClave.Text = String.Empty;
        }
    }
}
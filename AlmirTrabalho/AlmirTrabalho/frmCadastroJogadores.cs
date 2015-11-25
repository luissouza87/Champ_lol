using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmirTrabalho
{
    public partial class frmCadastroJogadores : Form
    {
        public frmCadastroJogadores()
        {
            InitializeComponent();
        }
        private void habilitaCampos(bool status)
        {
            txbNome.Enabled = status;
            txbIdade.Enabled = status;
            txbNick.Enabled = status;
            btnCadastro.Enabled = !status;
            btnCancelar.Enabled = status;
            btnInserir.Enabled = status;
            btnSair.Enabled = !status;
        }

        private void frmCadastroJogadores_Load(object sender, EventArgs e)
        {
            habilitaCampos(false);
            lblTime.Visible = false;
            cbbTime.Visible = false;
        }

        private void rdbSemTime_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Visible = false;
            cbbTime.Visible = false;
        }

        private void rdbComTime_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            cbbTime.Visible = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();// Fecha tela
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            txbNome.Focus();
            rdbSemTime.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaCampos(false);
            txbNome.Text = "";
            txbIdade.Text = "";
            txbNick.Text = "";
            rdbSemTime.Checked = false;
            rdbComTime.Checked = false;
            lblTime.Visible = false;
            cbbTime.Visible = false;
        }
    }
}

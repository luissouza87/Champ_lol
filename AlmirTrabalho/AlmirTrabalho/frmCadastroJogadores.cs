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
            lblCodT.Visible = false;
            txbCodT.Visible = false;

            Camadas.DAL.Jogador dalJogador = new Camadas.DAL.Jogador();
            dgvJogadores.DataSource = dalJogador.Select();

        }

        private void rdbSemTime_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Visible = false;
            cbbTime.Visible = false;
            lblCodT.Visible = false;
            txbCodT.Visible = false;
        }

        private void rdbComTime_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            cbbTime.Visible = true;
            lblCodT.Visible = true;
            txbCodT.Visible = true;

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
            lblCodT.Visible = false;
            txbCodT.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Jogadores Jogador = new Camadas.MODEL.Jogadores();
            Camadas.DAL.Jogador dalJogador = new Camadas.DAL.Jogador();
            Jogador.id = Convert.ToInt32(lblId.Text);
            Jogador.nome = txbNome.Text;
            Jogador.idade = Convert.ToInt32(txbIdade.Text);
            Jogador.nickname = txbNick.Text;
            if (rdbSemTime.Checked == true)
            {
                Jogador.idTime = Convert.ToInt32(1);
            }
            else
            {
                Jogador.idTime = Convert.ToInt32(txbCodT.Text);
            }

            dalJogador.Insert(Jogador);
            dgvJogadores.DataSource = dalJogador.Select();

        }
    }
}

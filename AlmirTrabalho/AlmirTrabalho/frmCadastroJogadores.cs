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

        private void recuperavalorTime()
        {
            List<Camadas.MODEL.time> listaTime = new List<Camadas.MODEL.time>();
            Camadas.BLL.Time bllTime = new Camadas.BLL.Time();
            int idTime = Convert.ToInt32(txbCodT.Text);
            if (idTime > 0)
            {
                listaTime = bllTime.SelectById(idTime);
                if (listaTime != null)
                    txbCodT.Text = listaTime[0].id.ToString();
                else txbCodT.Text = "0";
            }
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

            List<Camadas.MODEL.time> ListaTime = new List<Camadas.MODEL.time>();
            Camadas.BLL.Time bllTime = new Camadas.BLL.Time();
            ListaTime = bllTime.Select();
            cbbTime.DisplayMember = "nome";
            cbbTime.ValueMember = "id";
            cbbTime.DataSource = ListaTime;

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

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txbCodT.Text = cbbTime.SelectedValue.ToString();
            recuperavalorTime();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Jogadores Jogador = new Camadas.MODEL.Jogadores();
            Camadas.DAL.Jogador dalJogador = new Camadas.DAL.Jogador();
            Jogador.id = Convert.ToInt32(txtid.Text);
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

            dalJogador.Update(Jogador);
            dgvJogadores.DataSource = dalJogador.Select();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Jogadores Jogadores = new Camadas.MODEL.Jogadores();
            Camadas.DAL.Jogador daljogador = new Camadas.DAL.Jogador();
            Jogadores.id = Convert.ToInt32(txtid.Text);


            daljogador.Delete(Jogadores);
            dgvJogadores.DataSource = daljogador.Select();

        }
    }
}

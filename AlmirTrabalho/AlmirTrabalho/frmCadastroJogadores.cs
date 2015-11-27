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
            btnCancelarC.Enabled = status;
            btnInserir.Enabled = status;
            btnSair.Enabled = !status;
            btnAtualizar.Enabled = !status;
            btnDeletar.Enabled = !status;
        }
        private void idHab(bool status, string info)
        {
            lblId.Visible = status;
            txtid.Visible = status;
            lbId.Visible = status;
            lblInfo.Visible = status;
            lblInfo.Text = info;
        }
        private void limpaCampos()
        {
            txtid.Text = "";
            txbNome.Text = "";
            txbIdade.Text = "";
            txbNick.Text = "";
        }
        private void radControl(bool status)
        {
            rdbComTime.Enabled = status;
            rdbSemTime.Enabled = status;
            rdbSemTime.Checked = status;
            rdbComTime.Checked = status;
        }
        private void timeV(bool status)
        {
            lblTime.Visible = status;
            cbbTime.Visible = status;
            lblCodT.Visible = status;
            txbCodT.Visible = status;
        }

        private void frmCadastroJogadores_Load(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            radControl(false);
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
            btnInserir.Visible = false;
            btnCancelarC.Visible = false;
            btUpdate.Visible = false;
            btnCancelarA.Visible = false;
            btDeletar.Visible = false;
            btnCancelarD.Visible = false;
            idHab(false,@"\/");

        }

        private void rdbSemTime_CheckedChanged(object sender, EventArgs e)
        {
            timeV(false);
        }

        private void rdbComTime_CheckedChanged(object sender, EventArgs e)
        {
            timeV(true);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();// Fecha tela
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            radControl(true);
            txbNome.Focus();
            rdbSemTime.Checked = true;
            btnInserir.Visible = true;
            btnCancelarC.Visible = true;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            txbNome.Text = "";
            txbIdade.Text = "";
            txbNick.Text = "";
            radControl(false);
            timeV(false);
            btnInserir.Visible = false;
            btnCancelarC.Visible = false;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
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
            limpaCampos();
            radControl(false);
            timeV(false);
            habilitaCampos(false);
            btnInserir.Visible = false;
            btnCancelarC.Visible = false;
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
            limpaCampos();
            idHab(false,@"\/");
            radControl(false);
            timeV(false);
            habilitaCampos(false);
            btnCancelarA.Visible = false;
            btUpdate.Visible = false;

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Jogadores Jogadores = new Camadas.MODEL.Jogadores();
            Camadas.DAL.Jogador daljogador = new Camadas.DAL.Jogador();
            Jogadores.id = Convert.ToInt32(txtid.Text);


            daljogador.Delete(Jogadores);
            dgvJogadores.DataSource = daljogador.Select();
            limpaCampos();
            idHab(false,@"\/");
            habilitaCampos(false);
            radControl(false);
            timeV(false);
            btnCancelarD.Visible = false;
            btDeletar.Visible = false;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            radControl(true);
            rdbSemTime.Checked = true;
            btnCancelarA.Visible = true;
            btUpdate.Visible = true;
            idHab(true,@"\/ Selecione a baixo p/ Atualizar!");
            btUpdate.Enabled = false;
        }

        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            btnCancelarA.Visible = false;
            btUpdate.Visible = false;
            idHab(false,@"\/");
            radControl(false);
            timeV(false);
        }

        private void btnCancelarD_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            radControl(false);
            timeV(false);
            btnCancelarD.Visible = false;
            btDeletar.Visible = false;
            idHab(false,@"\/");
            

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            idHab(true, @"\/ Selecione a baixo p/ Deletar!");
            limpaCampos();
            habilitaCampos(true);
            btnCancelarD.Visible = true;
            btDeletar.Visible = true;
            btDeletar.Enabled = false;
        }

        private void dgvJogadores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dgvJogadores.SelectedRows[0].Cells[0].Value.ToString();
            txbNome.Text = dgvJogadores.SelectedRows[0].Cells[1].Value.ToString();
            txbIdade.Text = dgvJogadores.SelectedRows[0].Cells[2].Value.ToString();
            txbNick.Text = dgvJogadores.SelectedRows[0].Cells[3].Value.ToString();
            btUpdate.Enabled = true;
            btDeletar.Enabled = true;
        }
    }
}

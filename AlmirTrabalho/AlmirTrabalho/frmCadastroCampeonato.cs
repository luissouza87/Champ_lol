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
    public partial class frmCadastroCampeonato : Form
    {
        public frmCadastroCampeonato()
        {
            InitializeComponent();
        }

        private void limpaCampos()
        {
            txtIdUp.Text = "";
            txtNome.Text = "";
            txtCapacidade.Text = "";
            txtLocal.Text = "";
            txtPremiacao.Text = "";
        }
        private void editDelet(bool status, string info)
        {
            lblid.Visible = status;
            txtIdUp.Visible = status;
            lblInfo.Visible = status;
            lblInfo.Text = info;
        }

        private void habilitaCampos(bool status)
        {
            txtIdUp.Enabled = status;
            txtNome.Enabled = status;
            txtCapacidade.Enabled = status;
            txtLocal.Enabled = status;
            txtPremiacao.Enabled = status;
        }

        private void btcadastar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.campeonato Campeonato = new Camadas.MODEL.campeonato();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            Campeonato.local = txtLocal.Text;
            Campeonato.nome = txtNome.Text;
            Campeonato.premiacao = txtPremiacao.Text;
            Campeonato.capacidade = Convert.ToInt32(txtCapacidade.Text);

            dalCamp.Insert(Campeonato);
            dgvCadasCamp.DataSource = dalCamp.Select();

            habilitaCampos(false);
            btcadastar.Visible = false;
            btnCanC.Visible = false;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btSair.Enabled = true;
            limpaCampos();
            
        }

        private void frmCadastroCampeonato_Load(object sender, EventArgs e)
        {
            limpaCampos();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            dgvCadasCamp.DataSource = dalCamp.Select();
            habilitaCampos(false);
            btcadastar.Visible = false;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            btnCanA.Visible = false;
            btnCanC.Visible = false;
            btnCanD.Visible = false;
            lblid.Visible = false;
            lblInfo.Visible = false;
            txtIdUp.Visible = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.campeonato Campeonato = new Camadas.MODEL.campeonato();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            Campeonato.id = Convert.ToInt32(txtIdUp.Text);
            Campeonato.local = txtLocal.Text;
            Campeonato.nome = txtNome.Text;
            Campeonato.premiacao = txtPremiacao.Text;
            Campeonato.capacidade = Convert.ToInt32(txtCapacidade.Text);

            dalCamp.Update(Campeonato);//inseri as informacoes digitadas no banco
            dgvCadasCamp.DataSource = dalCamp.Select();//mostrar banco 
            
            habilitaCampos(false);
            btUpdate.Visible = false;
            btnCanA.Visible = false;
            btnCadastrar.Enabled = true;
            btnDeletar.Enabled = true;
            btSair.Enabled = true;
            limpaCampos();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.campeonato Campeonato = new Camadas.MODEL.campeonato();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            Campeonato.id = Convert.ToInt32(txtIdUp.Text);
            

            dalCamp.Delete(Campeonato);
            dgvCadasCamp.DataSource = dalCamp.Select();//mostrar banco 
            
            habilitaCampos(false);
            btDelete.Visible = false;
            btnCanD.Visible = false;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = true;
            btSair.Enabled = true;
            limpaCampos();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limpaCampos();
            txtNome.Focus();
            txtIdUp.Enabled = false;
            btcadastar.Visible = true;
            btnCanC.Visible = true;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btSair.Enabled = false;
        }

        private void btnCanC_Click(object sender, EventArgs e)
        {
            habilitaCampos(false);
            btcadastar.Visible = false;
            btnCanC.Visible = false;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btSair.Enabled = true;
            limpaCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limpaCampos();
            btUpdate.Visible = true;
            btnCanA.Visible = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
            btSair.Enabled = false;
            lblid.Visible = true;
            editDelet(true, "<-Informe o codigo para atualização!");
            txtIdUp.Focus();
            
        }

        private void btnCanA_Click(object sender, EventArgs e)
        {
            habilitaCampos(false);
            btUpdate.Visible = false;
            btnCanA.Visible = false;
            btnCadastrar.Enabled = true;
            btnDeletar.Enabled = true;
            btSair.Enabled = true;
            editDelet(false, "<-");
            limpaCampos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            txtIdUp.Enabled = true;
            btDelete.Visible = true;
            btnCanD.Visible = true;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = false;
            btSair.Enabled = false;
            editDelet(true, "<-Informe o codigo para deletar!");
            txtIdUp.Focus();
        }

        private void btnCanD_Click(object sender, EventArgs e)
        {
            habilitaCampos(false);
            btDelete.Visible = false;
            btnCanD.Visible = false;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = true;
            btSair.Enabled = true;
            editDelet(false, "<-");
            limpaCampos();
        }
    }
}

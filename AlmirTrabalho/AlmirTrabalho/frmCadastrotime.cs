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
    public partial class frmCadastrotime : Form
    {
        public frmCadastrotime()
        {
            InitializeComponent();
        }
        bool delete = false;

        private void habilitaCampos(bool status)
        {
            txtNome.Enabled = status;
            txtCriador.Enabled = status;
            txtPais.Enabled = status;
        }
        private void btnControl(bool status)
        {
            btnCad.Enabled = status;
            btnAtualizar.Enabled = status;
            btnDeletar.Enabled = status;
            btnSair.Enabled = status;
        }

        private void limpaCampos()
        {
            txtNome.Text = "";
            txtCriador.Text = "";
            txtPais.Text = "";
            txtId.Text = "";
        }

        private void idHab(bool status, string info)
        {
            lblid.Visible = status;
            txtId.Visible = status;
            lblInfo.Visible = status;
            lblInfo.Text = info;
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.time Times = new Camadas.MODEL.time();
            Camadas.DAL.Time dalTimes = new Camadas.DAL.Time();
            Times.nome = txtNome.Text;
            Times.criador = txtCriador.Text;
            Times.pais = txtPais.Text;
            Times.qt_jogadores = Convert.ToInt32(lblMax.Text);

            dalTimes.Insert(Times);
            dgvCadasTimes.DataSource = dalTimes.Select();
        }*/

        private void frmCadastrotime_Load(object sender, EventArgs e)
        {
            limpaCampos();
            Camadas.DAL.Time dalTime = new Camadas.DAL.Time();
            dgvCadasTimes.DataSource = dalTime.Select();
            habilitaCampos(false);
            btnCancelar.Enabled = false;
            btnCadastrar.Visible = false;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            idHab(false, @"\/");

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.time Times = new Camadas.MODEL.time();
            Camadas.DAL.Time daltime = new Camadas.DAL.Time();
            Times.id = Convert.ToInt32(txtId.Text);
            Times.nome = txtNome.Text;
            Times.criador = txtCriador.Text;
            Times.pais = txtPais.Text;
            Times.qt_jogadores = Convert.ToInt32(lblMax.Text);


            daltime.Update(Times);
            dgvCadasTimes.DataSource = daltime.Select();

            btnControl(true);
            btUpdate.Visible = false;
            limpaCampos();
            dgvCadasTimes.Enabled = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.time Times = new Camadas.MODEL.time();
            Camadas.DAL.Time daltime = new Camadas.DAL.Time();
            Times.id = Convert.ToInt32(txtId.Text);


            daltime.Delete(Times);
            dgvCadasTimes.DataSource = daltime.Select();
            btnControl(true);
            btDelete.Visible = false;
            limpaCampos();
            delete = false;
            dgvCadasTimes.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.time Times = new Camadas.MODEL.time();
            Camadas.DAL.Time dalTimes = new Camadas.DAL.Time();
            Times.nome = txtNome.Text;
            Times.criador = txtCriador.Text;
            Times.pais = txtPais.Text;
            Times.qt_jogadores = Convert.ToInt32(lblMax.Text);

            dalTimes.Insert(Times);
            dgvCadasTimes.DataSource = dalTimes.Select();
            btnControl(true);
            btnCadastrar.Visible = false;
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaCampos(false);
            btnCancelar.Enabled = false;
            btnControl(true);
            btnCadastrar.Visible = false;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            limpaCampos();
            lblMax.Text = "5";
            idHab(false, @"\/");
            delete = false;
            dgvCadasTimes.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            btnCancelar.Enabled = true;
            btnControl(false);
            btnCadastrar.Visible = true;
            limpaCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnControl(false);
            btUpdate.Visible = true;
            btUpdate.Enabled = false;
            limpaCampos();
            idHab(true, @"Selecione abaixo p/ editar!");
            dgvCadasTimes.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            delete = true;
            btnCancelar.Enabled = true;
            btnControl(false);
            btDelete.Enabled = false;
            btDelete.Visible = true;
            limpaCampos();
            idHab(true, @"Selecione abaixo p/ deletar!");
            dgvCadasTimes.Enabled = true;
        }

        private void dgvCadasTimes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dgvCadasTimes.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvCadasTimes.SelectedRows[0].Cells[1].Value.ToString();
            txtCriador.Text = dgvCadasTimes.SelectedRows[0].Cells[2].Value.ToString();
            txtPais.Text = dgvCadasTimes.SelectedRows[0].Cells[3].Value.ToString();
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            if (delete != true)
            {
                habilitaCampos(true);    
            }
            
        }
    }
}

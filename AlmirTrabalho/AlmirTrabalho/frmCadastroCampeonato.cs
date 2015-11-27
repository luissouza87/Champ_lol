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

        private void btcadastar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.campeonato Campeonato = new Camadas.MODEL.campeonato();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            Campeonato.id = Convert.ToInt32(lblmenos.Text);
            Campeonato.local = txtLocal.Text;
            Campeonato.nome = txtNome.Text;
            Campeonato.premiacao = txtPremiacao.Text;
            Campeonato.capacidade = Convert.ToInt32(txtCapacidade.Text);

            dalCamp.Insert(Campeonato);//inseri as informacoes digitadas no banco
            dgvCadasCamp.DataSource = dalCamp.Select();//mostrar banco 
            
        }

        private void frmCadastroCampeonato_Load(object sender, EventArgs e)
        {
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            dgvCadasCamp.DataSource = dalCamp.Select();

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
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.campeonato Campeonato = new Camadas.MODEL.campeonato();
            Camadas.DAL.campeonato dalCamp = new Camadas.DAL.campeonato();
            Campeonato.id = Convert.ToInt32(txtIdUp.Text);
            

            dalCamp.Delete(Campeonato);
            dgvCadasCamp.DataSource = dalCamp.Select();//mostrar banco 

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

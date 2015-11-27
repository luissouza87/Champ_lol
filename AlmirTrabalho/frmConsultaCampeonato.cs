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
    public partial class frmConsultaCampeonato : Form
    {
        Camadas.BLL.campeonato bllCampeonato = new Camadas.BLL.campeonato();
        List<Camadas.MODEL.campeonato> listaCampeonato = new List<Camadas.MODEL.campeonato>();

        public frmConsultaCampeonato()
        {
            InitializeComponent();
        }

        
        private void setVisible(bool status, string nN)
        {
            lblPesquisa.Visible = status;
            txbPesquisa.Visible = status;
            btnPesquisa.Visible = status;
            lblPesquisa.Text = nN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaJogador_Load(object sender, EventArgs e)
        {
            setVisible(false, "");
            rdbTodos.Checked = true;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(false, "");
            listaCampeonato = bllCampeonato.Select();
            dgvConsulJogador.DataSource = listaCampeonato;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(true, "Insira o País: ");
            txbPesquisa.Text = "";
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
                listaCampeonato = bllCampeonato.SelectPorPais(txbPesquisa.Text);
                dgvConsulJogador.DataSource = listaCampeonato;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmCadastroCampeonato frmCadasCampeonato = new frmCadastroCampeonato();
            frmCadasCampeonato.Show();
        }
    }
}

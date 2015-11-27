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
    public partial class frmConsultaJogador : Form
    {

        public frmConsultaJogador()
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

            Camadas.DAL.Jogador dalJogador = new Camadas.DAL.Jogador();
            dgvConsulJogador.DataSource = dalJogador.Select();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(false, "");
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(true, "Insira o Nome: ");
            txbPesquisa.Text = "";
        }

        private void rdbNick_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(true, "Insira o NickName: ");
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
           
        }
    }
}

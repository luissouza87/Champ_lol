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
        Camadas.BLL.jogador bllJogador = new Camadas.BLL.jogador();
        List<Camadas.MODEL.Jogadores> listaJogadores = new List<Camadas.MODEL.Jogadores>();

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
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            setVisible(false, "");
            listaJogadores = bllJogador.Select();
            dgvConsulJogador.DataSource = listaJogadores;
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
            if (rdbNome.Checked)
                listaJogadores = bllJogador.SelectPorNome(txbPesquisa.Text);
            else if (rdbNick.Checked)
                listaJogadores = bllJogador.SelectPorNickname(txbPesquisa.Text);
                dgvConsulJogador.DataSource = listaJogadores;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmCadastroJogadores frmCadasJogadores = new frmCadastroJogadores();
            frmCadasJogadores.Show();
        }
    }
}

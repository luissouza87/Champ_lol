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
    public partial class frmConsultaTimes : Form
    {
        Camadas.BLL.Time bllTimes = new Camadas.BLL.Time();
        List<Camadas.MODEL.time> listaTimes = new List<Camadas.MODEL.time>();

        public frmConsultaTimes()
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
            listaTimes = bllTimes.Select();
            dgvConsulJogador.DataSource = listaTimes;
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
                listaTimes = bllTimes.SelectPorTime(txbPesquisa.Text);
            else if (rdbNick.Checked)
                listaTimes = bllTimes.SelectPorID(Convert.ToInt32(txbPesquisa.Text));
                dgvConsulJogador.DataSource = listaTimes;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmCadastrotime frmCadasTime = new frmCadastrotime();
            frmCadasTime.Show();
        }
    }
}

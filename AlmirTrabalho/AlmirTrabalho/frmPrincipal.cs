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
    public partial class fmprincipal : Form
    {
        public fmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();// Fecha e mata os arquivos da memoria 
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void participantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadastroJogadores frmCadasJog = new frmCadastroJogadores();//chamar tela CadastroJogadores
            frmCadasJog.MdiParent = this;
            frmCadasJog.Show();//Mostrar tela
        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrotime frmCadasTim = new frmCadastrotime();
            frmCadasTim.MdiParent = this;
            frmCadasTim.Show();
        }

        private void campeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCampeonato frmCadasCamp = new frmCadastroCampeonato();
            frmCadasCamp.MdiParent = this;
            frmCadasCamp.Show();
        }

        private void timesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaJogador frmConsulJogador = new frmConsultaJogador();
            frmConsulJogador.MdiParent = this;
            frmConsulJogador.Show();
        }
    }
}

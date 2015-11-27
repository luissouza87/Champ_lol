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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.time Times = new Camadas.MODEL.time();
            Camadas.DAL.Time dalTimes = new Camadas.DAL.Time();
            Times.id = Convert.ToInt32(lblidmais.Text);
            Times.nome = txtNome.Text;
            Times.criador = txtCriador.Text;
            Times.pais = txtPais.Text;
            Times.qt_jogadores = Convert.ToInt32(lblMax.Text);

            dalTimes.Insert(Times);//inseri as informacoes digitadas no banco
            dgvCadasTimes.DataSource = dalTimes.Select();//mostrar banco 
        }

        private void frmCadastrotime_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Time dalTime = new Camadas.DAL.Time();
            dgvCadasTimes.DataSource = dalTime.Select();
        }
    }
}

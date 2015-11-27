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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptCampeonato rCamp = new rptCampeonato();
            dtsCamp dsCamp = new dtsCamp(); //cria espaço na memoria pra armazenar dados
            dtsCampTableAdapters.CAMPEONATOTableAdapter taCamp = new dtsCampTableAdapters.CAMPEONATOTableAdapter();
            //taCamp executa SQL no Banco de dados e prencher tabela/lista no dataset dtCamp
            taCamp.Fill(dsCamp.CAMPEONATO);// carrega a tabela/lista com dados
            rCamp.SetDataSource(dsCamp); //atualiza os dados do relatório
            crvRelatorios.ReportSource = rCamp; // vincula relatorio com controle apresentação de relatório
        }
    }
}

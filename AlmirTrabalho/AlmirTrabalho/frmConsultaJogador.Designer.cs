namespace AlmirTrabalho
{
    partial class frmConsultaJogador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsulJogador = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbNick = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulJogador)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulJogador
            // 
            this.dgvConsulJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulJogador.Location = new System.Drawing.Point(32, 122);
            this.dgvConsulJogador.Name = "dgvConsulJogador";
            this.dgvConsulJogador.Size = new System.Drawing.Size(523, 186);
            this.dgvConsulJogador.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.rdbNick);
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Location = new System.Drawing.Point(32, 4);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(317, 44);
            this.gpbPesquisa.TabIndex = 2;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar por: ";
            // 
            // rdbNick
            // 
            this.rdbNick.AutoSize = true;
            this.rdbNick.Location = new System.Drawing.Point(228, 19);
            this.rdbNick.Name = "rdbNick";
            this.rdbNick.Size = new System.Drawing.Size(75, 17);
            this.rdbNick.TabIndex = 2;
            this.rdbNick.TabStop = true;
            this.rdbNick.Text = "NickName";
            this.rdbNick.UseVisualStyleBackColor = true;
            this.rdbNick.CheckedChanged += new System.EventHandler(this.rdbNick_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(123, 19);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(20, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(32, 51);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(89, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Tipo de Pesquisa";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(32, 66);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(523, 20);
            this.txbPesquisa.TabIndex = 4;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(32, 93);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // frmConsultaJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvConsulJogador);
            this.Name = "frmConsultaJogador";
            this.Text = "Consulta de Jogador";
            this.Load += new System.EventHandler(this.frmConsultaJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulJogador)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulJogador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rdbNick;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
    }
}
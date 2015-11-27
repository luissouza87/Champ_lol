namespace AlmirTrabalho
{
    partial class frmCadastroJogadores
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.gpbTime = new System.Windows.Forms.GroupBox();
            this.rdbComTime = new System.Windows.Forms.RadioButton();
            this.rdbSemTime = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbNick = new System.Windows.Forms.TextBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.lblCodT = new System.Windows.Forms.Label();
            this.txbCodT = new System.Windows.Forms.TextBox();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.btnCancelarD = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gpbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(24, 258);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(169, 27);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "&Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInserir.Location = new System.Drawing.Point(24, 291);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(84, 27);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSair.Location = new System.Drawing.Point(22, 465);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(513, 27);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbId.Location = new System.Drawing.Point(103, 41);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(52, 27);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNome.Location = new System.Drawing.Point(76, 68);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(79, 27);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome :";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbIdade.Location = new System.Drawing.Point(73, 95);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(82, 27);
            this.lbIdade.TabIndex = 6;
            this.lbIdade.Text = "Idade :";
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNick.Location = new System.Drawing.Point(35, 122);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(120, 27);
            this.lbNick.TabIndex = 7;
            this.lbNick.Text = "NickName :";
            // 
            // gpbTime
            // 
            this.gpbTime.Controls.Add(this.rdbComTime);
            this.gpbTime.Controls.Add(this.rdbSemTime);
            this.gpbTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gpbTime.Location = new System.Drawing.Point(24, 152);
            this.gpbTime.Name = "gpbTime";
            this.gpbTime.Size = new System.Drawing.Size(131, 100);
            this.gpbTime.TabIndex = 8;
            this.gpbTime.TabStop = false;
            this.gpbTime.Text = "Time";
            // 
            // rdbComTime
            // 
            this.rdbComTime.AutoSize = true;
            this.rdbComTime.Location = new System.Drawing.Point(8, 62);
            this.rdbComTime.Name = "rdbComTime";
            this.rdbComTime.Size = new System.Drawing.Size(119, 31);
            this.rdbComTime.TabIndex = 1;
            this.rdbComTime.Text = "Com Time";
            this.rdbComTime.UseVisualStyleBackColor = true;
            this.rdbComTime.CheckedChanged += new System.EventHandler(this.rdbComTime_CheckedChanged);
            // 
            // rdbSemTime
            // 
            this.rdbSemTime.AutoSize = true;
            this.rdbSemTime.Location = new System.Drawing.Point(8, 25);
            this.rdbSemTime.Name = "rdbSemTime";
            this.rdbSemTime.Size = new System.Drawing.Size(121, 31);
            this.rdbSemTime.TabIndex = 0;
            this.rdbSemTime.Text = "Sem Time";
            this.rdbSemTime.UseVisualStyleBackColor = true;
            this.rdbSemTime.CheckedChanged += new System.EventHandler(this.rdbSemTime_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTime.Location = new System.Drawing.Point(161, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(168, 27);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Selecione o Time";
            // 
            // cbbTime
            // 
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(335, 183);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(188, 21);
            this.cbbTime.TabIndex = 10;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged_1);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(166, 75);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(357, 20);
            this.txbNome.TabIndex = 11;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(166, 101);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(357, 20);
            this.txbIdade.TabIndex = 12;
            // 
            // txbNick
            // 
            this.txbNick.Location = new System.Drawing.Point(166, 127);
            this.txbNick.Name = "txbNick";
            this.txbNick.Size = new System.Drawing.Size(357, 20);
            this.txbNick.TabIndex = 13;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelarC.Location = new System.Drawing.Point(109, 291);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(84, 27);
            this.btnCancelarC.TabIndex = 14;
            this.btnCancelarC.Text = "&Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            this.btnCancelarC.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodT
            // 
            this.lblCodT.AutoSize = true;
            this.lblCodT.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCodT.Location = new System.Drawing.Point(170, 214);
            this.lblCodT.Name = "lblCodT";
            this.lblCodT.Size = new System.Drawing.Size(159, 27);
            this.lblCodT.TabIndex = 16;
            this.lblCodT.Text = "Codigo do Time:";
            // 
            // txbCodT
            // 
            this.txbCodT.Enabled = false;
            this.txbCodT.Location = new System.Drawing.Point(335, 221);
            this.txbCodT.Name = "txbCodT";
            this.txbCodT.Size = new System.Drawing.Size(57, 20);
            this.txbCodT.TabIndex = 17;
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Location = new System.Drawing.Point(24, 324);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.Size = new System.Drawing.Size(511, 133);
            this.dgvJogadores.TabIndex = 18;
            this.dgvJogadores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvJogadores_MouseDoubleClick);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(195, 291);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(84, 27);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "&Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(366, 291);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(84, 27);
            this.btDeletar.TabIndex = 20;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(166, 48);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 20);
            this.txtid.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblId.Location = new System.Drawing.Point(208, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 27);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "-1";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(195, 258);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(169, 27);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(366, 258);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(169, 27);
            this.btnDeletar.TabIndex = 23;
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelarA.Location = new System.Drawing.Point(280, 291);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(84, 27);
            this.btnCancelarA.TabIndex = 24;
            this.btnCancelarA.Text = "&Cancelar";
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // btnCancelarD
            // 
            this.btnCancelarD.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelarD.Location = new System.Drawing.Point(451, 291);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(84, 27);
            this.btnCancelarD.TabIndex = 25;
            this.btnCancelarD.Text = "&Cancelar";
            this.btnCancelarD.UseVisualStyleBackColor = true;
            this.btnCancelarD.Click += new System.EventHandler(this.btnCancelarD_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(161, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(32, 27);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "\\/";
            // 
            // frmCadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 504);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancelarD);
            this.Controls.Add(this.btnCancelarA);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.txbCodT);
            this.Controls.Add(this.lblCodT);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelarC);
            this.Controls.Add(this.txbNick);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.cbbTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gpbTime);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCadastro);
            this.Name = "frmCadastroJogadores";
            this.Text = "Cadastro Jogadores";
            this.Load += new System.EventHandler(this.frmCadastroJogadores_Load);
            this.gpbTime.ResumeLayout(false);
            this.gpbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.GroupBox gpbTime;
        private System.Windows.Forms.RadioButton rdbComTime;
        private System.Windows.Forms.RadioButton rdbSemTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbbTime;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbNick;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Label lblCodT;
        private System.Windows.Forms.TextBox txbCodT;
        private System.Windows.Forms.DataGridView dgvJogadores;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.Button btnCancelarD;
        private System.Windows.Forms.Label lblInfo;
    }
}
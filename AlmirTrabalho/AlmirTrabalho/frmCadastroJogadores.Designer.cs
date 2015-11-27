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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodT = new System.Windows.Forms.Label();
            this.txbCodT = new System.Windows.Forms.TextBox();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.gpbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(24, 261);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(97, 27);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "&Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInserir.Location = new System.Drawing.Point(127, 261);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(97, 27);
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
            this.btnSair.Size = new System.Drawing.Size(305, 27);
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
            this.lblTime.Location = new System.Drawing.Point(161, 152);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(168, 27);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Selecione o Time";
            // 
            // cbbTime
            // 
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(166, 182);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(163, 21);
            this.cbbTime.TabIndex = 10;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged_1);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(166, 75);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(163, 20);
            this.txbNome.TabIndex = 11;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(166, 101);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(163, 20);
            this.txbIdade.TabIndex = 12;
            // 
            // txbNick
            // 
            this.txbNick.Location = new System.Drawing.Point(166, 127);
            this.txbNick.Name = "txbNick";
            this.txbNick.Size = new System.Drawing.Size(163, 20);
            this.txbNick.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Location = new System.Drawing.Point(230, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblId.Location = new System.Drawing.Point(161, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 27);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "-1";
            // 
            // lblCodT
            // 
            this.lblCodT.AutoSize = true;
            this.lblCodT.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCodT.Location = new System.Drawing.Point(161, 214);
            this.lblCodT.Name = "lblCodT";
            this.lblCodT.Size = new System.Drawing.Size(105, 27);
            this.lblCodT.TabIndex = 16;
            this.lblCodT.Text = "Cod. Time";
            // 
            // txbCodT
            // 
            this.txbCodT.Enabled = false;
            this.txbCodT.Location = new System.Drawing.Point(272, 221);
            this.txbCodT.Name = "txbCodT";
            this.txbCodT.Size = new System.Drawing.Size(57, 20);
            this.txbCodT.TabIndex = 17;
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Location = new System.Drawing.Point(24, 294);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.Size = new System.Drawing.Size(303, 163);
            this.dgvJogadores.TabIndex = 18;
            // 
            // frmCadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.txbCodT);
            this.Controls.Add(this.lblCodT);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodT;
        private System.Windows.Forms.TextBox txbCodT;
        private System.Windows.Forms.DataGridView dgvJogadores;
    }
}
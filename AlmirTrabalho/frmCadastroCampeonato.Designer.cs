namespace AlmirTrabalho
{
    partial class frmCadastroCampeonato
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPrem = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPremiacao = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.dgvCadasCamp = new System.Windows.Forms.DataGridView();
            this.btcadastar = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.txtIdUp = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCanC = new System.Windows.Forms.Button();
            this.btnCanA = new System.Windows.Forms.Button();
            this.btnCanD = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(138, 5);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 27);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(53, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(137, 27);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Campeonato :";
            // 
            // lblPrem
            // 
            this.lblPrem.AutoSize = true;
            this.lblPrem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrem.Location = new System.Drawing.Point(70, 153);
            this.lblPrem.Name = "lblPrem";
            this.lblPrem.Size = new System.Drawing.Size(120, 27);
            this.lblPrem.TabIndex = 2;
            this.lblPrem.Text = "Premiação :";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(-3, 79);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(193, 27);
            this.lblCap.TabIndex = 3;
            this.lblCap.Text = "Quant Max. Times:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(116, 116);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(74, 27);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Local :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(190, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPremiacao
            // 
            this.txtPremiacao.Location = new System.Drawing.Point(190, 160);
            this.txtPremiacao.Name = "txtPremiacao";
            this.txtPremiacao.Size = new System.Drawing.Size(424, 20);
            this.txtPremiacao.TabIndex = 7;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(190, 123);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(424, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(190, 86);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(424, 20);
            this.txtCapacidade.TabIndex = 9;
            // 
            // dgvCadasCamp
            // 
            this.dgvCadasCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadasCamp.Location = new System.Drawing.Point(44, 245);
            this.dgvCadasCamp.Name = "dgvCadasCamp";
            this.dgvCadasCamp.Size = new System.Drawing.Size(545, 106);
            this.dgvCadasCamp.TabIndex = 10;
            this.dgvCadasCamp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCadasCamp_MouseDoubleClick);
            // 
            // btcadastar
            // 
            this.btcadastar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastar.Location = new System.Drawing.Point(44, 216);
            this.btcadastar.Name = "btcadastar";
            this.btcadastar.Size = new System.Drawing.Size(87, 23);
            this.btcadastar.TabIndex = 11;
            this.btcadastar.Text = "Confirmar";
            this.btcadastar.UseVisualStyleBackColor = true;
            this.btcadastar.Click += new System.EventHandler(this.btcadastar_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(226, 216);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(87, 23);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Confirmar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(408, 216);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(87, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Confirmar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(44, 357);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(545, 23);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtIdUp
            // 
            this.txtIdUp.Location = new System.Drawing.Point(190, 12);
            this.txtIdUp.Name = "txtIdUp";
            this.txtIdUp.Size = new System.Drawing.Size(34, 20);
            this.txtIdUp.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(44, 187);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(180, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(226, 186);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(180, 23);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(408, 187);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(180, 23);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCanC
            // 
            this.btnCanC.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanC.Location = new System.Drawing.Point(137, 216);
            this.btnCanC.Name = "btnCanC";
            this.btnCanC.Size = new System.Drawing.Size(87, 23);
            this.btnCanC.TabIndex = 19;
            this.btnCanC.Text = "Cancelar";
            this.btnCanC.UseVisualStyleBackColor = true;
            this.btnCanC.Click += new System.EventHandler(this.btnCanC_Click);
            // 
            // btnCanA
            // 
            this.btnCanA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanA.Location = new System.Drawing.Point(319, 216);
            this.btnCanA.Name = "btnCanA";
            this.btnCanA.Size = new System.Drawing.Size(87, 23);
            this.btnCanA.TabIndex = 20;
            this.btnCanA.Text = "Cancelar";
            this.btnCanA.UseVisualStyleBackColor = true;
            this.btnCanA.Click += new System.EventHandler(this.btnCanA_Click);
            // 
            // btnCanD
            // 
            this.btnCanD.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanD.Location = new System.Drawing.Point(501, 216);
            this.btnCanD.Name = "btnCanD";
            this.btnCanD.Size = new System.Drawing.Size(87, 23);
            this.btnCanD.TabIndex = 21;
            this.btnCanD.Text = "Cancelar";
            this.btnCanD.UseVisualStyleBackColor = true;
            this.btnCanD.Click += new System.EventHandler(this.btnCanD_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(230, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 27);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "<-";
            // 
            // frmCadastroCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCanD);
            this.Controls.Add(this.btnCanA);
            this.Controls.Add(this.btnCanC);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtIdUp);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btcadastar);
            this.Controls.Add(this.dgvCadasCamp);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtPremiacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblPrem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblid);
            this.Name = "frmCadastroCampeonato";
            this.Text = "Cadastro do Campeonato";
            this.Load += new System.EventHandler(this.frmCadastroCampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasCamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrem;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPremiacao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.DataGridView dgvCadasCamp;
        private System.Windows.Forms.Button btcadastar;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtIdUp;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCanC;
        private System.Windows.Forms.Button btnCanA;
        private System.Windows.Forms.Button btnCanD;
        private System.Windows.Forms.Label lblInfo;
    }
}
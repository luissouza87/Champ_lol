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
            this.lblmenos = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(138, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 27);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(53, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(137, 27);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Campeonato :";
            // 
            // lblPrem
            // 
            this.lblPrem.AutoSize = true;
            this.lblPrem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrem.Location = new System.Drawing.Point(70, 168);
            this.lblPrem.Name = "lblPrem";
            this.lblPrem.Size = new System.Drawing.Size(120, 27);
            this.lblPrem.TabIndex = 2;
            this.lblPrem.Text = "Premiação :";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(-3, 88);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(193, 27);
            this.lblCap.TabIndex = 3;
            this.lblCap.Text = "Quant Max. Times:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(116, 129);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(74, 27);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Local :";
            // 
            // lblmenos
            // 
            this.lblmenos.AutoSize = true;
            this.lblmenos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenos.Location = new System.Drawing.Point(183, 9);
            this.lblmenos.Name = "lblmenos";
            this.lblmenos.Size = new System.Drawing.Size(36, 27);
            this.lblmenos.TabIndex = 5;
            this.lblmenos.Text = "-1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPremiacao
            // 
            this.txtPremiacao.Location = new System.Drawing.Point(196, 172);
            this.txtPremiacao.Name = "txtPremiacao";
            this.txtPremiacao.Size = new System.Drawing.Size(424, 20);
            this.txtPremiacao.TabIndex = 7;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(196, 133);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(424, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(196, 92);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(424, 20);
            this.txtCapacidade.TabIndex = 9;
            // 
            // dgvCadasCamp
            // 
            this.dgvCadasCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadasCamp.Location = new System.Drawing.Point(46, 236);
            this.dgvCadasCamp.Name = "dgvCadasCamp";
            this.dgvCadasCamp.Size = new System.Drawing.Size(545, 153);
            this.dgvCadasCamp.TabIndex = 10;
            // 
            // btcadastar
            // 
            this.btcadastar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastar.Location = new System.Drawing.Point(14, 207);
            this.btcadastar.Name = "btcadastar";
            this.btcadastar.Size = new System.Drawing.Size(108, 23);
            this.btcadastar.TabIndex = 11;
            this.btcadastar.Text = "Cadastro";
            this.btcadastar.UseVisualStyleBackColor = true;
            this.btcadastar.Click += new System.EventHandler(this.btcadastar_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(180, 207);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(108, 23);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(346, 207);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Deletar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(512, 207);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(108, 23);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtIdUp
            // 
            this.txtIdUp.Location = new System.Drawing.Point(226, 12);
            this.txtIdUp.Name = "txtIdUp";
            this.txtIdUp.Size = new System.Drawing.Size(34, 20);
            this.txtIdUp.TabIndex = 15;
            // 
            // frmCadastroCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 405);
            this.ControlBox = false;
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
            this.Controls.Add(this.lblmenos);
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
        private System.Windows.Forms.Label lblmenos;
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
    }
}
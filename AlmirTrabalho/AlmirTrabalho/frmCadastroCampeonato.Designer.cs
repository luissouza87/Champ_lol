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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(87, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 27);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 27);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblPrem
            // 
            this.lblPrem.AutoSize = true;
            this.lblPrem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrem.Location = new System.Drawing.Point(19, 165);
            this.lblPrem.Name = "lblPrem";
            this.lblPrem.Size = new System.Drawing.Size(120, 27);
            this.lblPrem.TabIndex = 2;
            this.lblPrem.Text = "Premiação :";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(8, 87);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(131, 27);
            this.lblCap.TabIndex = 3;
            this.lblCap.Text = "Capacidade :";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(65, 126);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(74, 27);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Local :";
            // 
            // lblmenos
            // 
            this.lblmenos.AutoSize = true;
            this.lblmenos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenos.Location = new System.Drawing.Point(145, 9);
            this.lblmenos.Name = "lblmenos";
            this.lblmenos.Size = new System.Drawing.Size(36, 27);
            this.lblmenos.TabIndex = 5;
            this.lblmenos.Text = "-1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(344, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPremiacao
            // 
            this.txtPremiacao.Location = new System.Drawing.Point(145, 172);
            this.txtPremiacao.Name = "txtPremiacao";
            this.txtPremiacao.Size = new System.Drawing.Size(344, 20);
            this.txtPremiacao.TabIndex = 7;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(145, 133);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(344, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(145, 92);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(344, 20);
            this.txtCapacidade.TabIndex = 9;
            // 
            // dgvCadasCamp
            // 
            this.dgvCadasCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadasCamp.Location = new System.Drawing.Point(38, 240);
            this.dgvCadasCamp.Name = "dgvCadasCamp";
            this.dgvCadasCamp.Size = new System.Drawing.Size(617, 153);
            this.dgvCadasCamp.TabIndex = 10;
            // 
            // btcadastar
            // 
            this.btcadastar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastar.Location = new System.Drawing.Point(38, 207);
            this.btcadastar.Name = "btcadastar";
            this.btcadastar.Size = new System.Drawing.Size(85, 23);
            this.btcadastar.TabIndex = 11;
            this.btcadastar.Text = "Cadastro";
            this.btcadastar.UseVisualStyleBackColor = true;
            this.btcadastar.Click += new System.EventHandler(this.btcadastar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmCadastroCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 405);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Text = "frmCadastroCampeonato";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
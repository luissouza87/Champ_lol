namespace AlmirTrabalho
{
    partial class frmCadastrotime
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
            this.lblCriador = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblidmais = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCriador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvCadasTimes = new System.Windows.Forms.DataGridView();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(48, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 27);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 27);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblCriador
            // 
            this.lblCriador.AutoSize = true;
            this.lblCriador.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriador.Location = new System.Drawing.Point(5, 85);
            this.lblCriador.Name = "lblCriador";
            this.lblCriador.Size = new System.Drawing.Size(95, 27);
            this.lblCriador.TabIndex = 2;
            this.lblCriador.Text = "Criador :";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(37, 116);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(63, 27);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País :";
            // 
            // lblidmais
            // 
            this.lblidmais.AutoSize = true;
            this.lblidmais.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidmais.Location = new System.Drawing.Point(106, 23);
            this.lblidmais.Name = "lblidmais";
            this.lblidmais.Size = new System.Drawing.Size(29, 27);
            this.lblidmais.TabIndex = 4;
            this.lblidmais.Text = "-1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(106, 117);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(282, 20);
            this.txtPais.TabIndex = 6;
            // 
            // txtCriador
            // 
            this.txtCriador.Location = new System.Drawing.Point(106, 88);
            this.txtCriador.Name = "txtCriador";
            this.txtCriador.Size = new System.Drawing.Size(282, 20);
            this.txtCriador.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(107, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(210, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(313, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvCadasTimes
            // 
            this.dgvCadasTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadasTimes.Location = new System.Drawing.Point(12, 225);
            this.dgvCadasTimes.Name = "dgvCadasTimes";
            this.dgvCadasTimes.Size = new System.Drawing.Size(381, 97);
            this.dgvCadasTimes.TabIndex = 11;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 143);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(192, 27);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Max. Integrantes :";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(210, 143);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(24, 27);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "5";
            // 
            // frmCadastrotime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 334);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dgvCadasTimes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCriador);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblidmais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCriador);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblid);
            this.Name = "frmCadastrotime";
            this.Text = "Cadastrar Time";
            this.Load += new System.EventHandler(this.frmCadastrotime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadasTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCriador;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblidmais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCriador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvCadasTimes;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblMax;
    }
}
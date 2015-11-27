namespace AlmirTrabalho
{
    partial class frmRelatorios
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnJogador = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.crvRelatorios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnJogador);
            this.splitContainer1.Panel1.Controls.Add(this.btnTime);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvRelatorios);
            this.splitContainer1.Size = new System.Drawing.Size(703, 490);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(21, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Campeonatos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTime.Location = new System.Drawing.Point(21, 96);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(87, 23);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = true;
            // 
            // btnJogador
            // 
            this.btnJogador.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnJogador.Location = new System.Drawing.Point(21, 162);
            this.btnJogador.Name = "btnJogador";
            this.btnJogador.Size = new System.Drawing.Size(87, 23);
            this.btnJogador.TabIndex = 2;
            this.btnJogador.Text = "Jogador";
            this.btnJogador.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // crvRelatorios
            // 
            this.crvRelatorios.ActiveViewIndex = -1;
            this.crvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorios.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorios.Name = "crvRelatorios";
            this.crvRelatorios.Size = new System.Drawing.Size(574, 490);
            this.crvRelatorios.TabIndex = 0;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnJogador;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorios;
    }
}
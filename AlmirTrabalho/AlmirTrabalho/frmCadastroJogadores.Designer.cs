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
            this.btCadastro = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCadastro
            // 
            this.btCadastro.Location = new System.Drawing.Point(34, 195);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(104, 23);
            this.btCadastro.TabIndex = 0;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = true;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(155, 195);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(103, 23);
            this.btApagar.TabIndex = 1;
            this.btApagar.Text = "Apagar Cadastro";
            this.btApagar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(274, 195);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(104, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(394, 195);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(104, 23);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(34, 44);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 13);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(34, 66);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome :";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(34, 91);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(40, 13);
            this.lbIdade.TabIndex = 6;
            this.lbIdade.Text = "Idade :";
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Location = new System.Drawing.Point(34, 118);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(63, 13);
            this.lbNick.TabIndex = 7;
            this.lbNick.Text = "NickName :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(34, 142);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 13);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Time :";
            // 
            // frmCadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.ControlBox = false;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btCadastro);
            this.Name = "frmCadastroJogadores";
            this.Text = "Cadastro Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.Label lbTime;
    }
}
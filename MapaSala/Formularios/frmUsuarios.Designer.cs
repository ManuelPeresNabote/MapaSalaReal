namespace MapaSala.Formularios
{
    partial class frmUsuarios
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
            this.Usuários = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.bntNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtUsuarios = new System.Windows.Forms.DataGridView();
            this.Usuários.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuários
            // 
            this.Usuários.Controls.Add(this.txtPesquisar);
            this.Usuários.Controls.Add(this.bntNovo);
            this.Usuários.Controls.Add(this.label1);
            this.Usuários.Location = new System.Drawing.Point(12, 12);
            this.Usuários.Name = "Usuários";
            this.Usuários.Size = new System.Drawing.Size(776, 68);
            this.Usuários.TabIndex = 0;
            this.Usuários.TabStop = false;
            this.Usuários.Text = "Usuários";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(276, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(482, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(6, 24);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(122, 23);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Adicionar Usuário";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // dtUsuarios
            // 
            this.dtUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsuarios.Location = new System.Drawing.Point(12, 86);
            this.dtUsuarios.Name = "dtUsuarios";
            this.dtUsuarios.Size = new System.Drawing.Size(776, 352);
            this.dtUsuarios.TabIndex = 2;
            this.dtUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuarios_CellContentClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtUsuarios);
            this.Controls.Add(this.Usuários);
            this.Name = "frmUsuarios";
            this.Text = "Usuários";
            this.Usuários.ResumeLayout(false);
            this.Usuários.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Usuários;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtUsuarios;
    }
}
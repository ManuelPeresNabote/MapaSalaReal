
namespace MapaSala.Formularios
{
    partial class frmDisciplina
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.bnt_Novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.AllowUserToAddRows = false;
            this.dtGridDisciplina.AllowUserToDeleteRows = false;
            this.dtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridDisciplina.BackgroundColor = System.Drawing.Color.Gray;
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(26, 145);
            this.dtGridDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.ReadOnly = true;
            this.dtGridDisciplina.RowHeadersWidth = 51;
            this.dtGridDisciplina.Size = new System.Drawing.Size(1026, 426);
            this.dtGridDisciplina.TabIndex = 7;
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            // 
            // bnt_Novo
            // 
            this.bnt_Novo.Location = new System.Drawing.Point(26, 84);
            this.bnt_Novo.Name = "bnt_Novo";
            this.bnt_Novo.Size = new System.Drawing.Size(196, 23);
            this.bnt_Novo.TabIndex = 8;
            this.bnt_Novo.Text = "Adicionar Disciplina";
            this.bnt_Novo.UseVisualStyleBackColor = true;
            this.bnt_Novo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(362, 84);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(372, 23);
            this.txtPesquisar.TabIndex = 10;
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_Novo);
            this.Controls.Add(this.dtGridDisciplina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplina";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.Button bnt_Novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}
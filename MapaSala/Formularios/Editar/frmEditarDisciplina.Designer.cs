
namespace MapaSala.Formularios.Editar
{
    partial class frmEditarDisciplina
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
            this.lbNomeDisciplina = new System.Windows.Forms.Label();
            this.lbSigla = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNomeDisciplina
            // 
            this.lbNomeDisciplina.AutoSize = true;
            this.lbNomeDisciplina.Location = new System.Drawing.Point(23, 88);
            this.lbNomeDisciplina.Name = "lbNomeDisciplina";
            this.lbNomeDisciplina.Size = new System.Drawing.Size(98, 13);
            this.lbNomeDisciplina.TabIndex = 0;
            this.lbNomeDisciplina.Text = "Nome da Disciplina";
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Location = new System.Drawing.Point(23, 156);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(30, 13);
            this.lbSigla.TabIndex = 1;
            this.lbSigla.Text = "Sigla";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(26, 223);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(26, 104);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(190, 20);
            this.txtNomeDisciplina.TabIndex = 3;
            this.txtNomeDisciplina.TextChanged += new System.EventHandler(this.txtNomeDisciplina_TextChanged);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(26, 172);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(190, 20);
            this.txtSigla.TabIndex = 4;
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(26, 317);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 5;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(86, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 13);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código:";
            // 
            // frmEditarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.lbSigla);
            this.Controls.Add(this.lbNomeDisciplina);
            this.Name = "frmEditarDisciplina";
            this.Text = "frmEditarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeDisciplina;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
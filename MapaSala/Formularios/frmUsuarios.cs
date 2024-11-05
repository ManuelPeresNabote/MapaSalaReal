using MapaSala.Classes;
using MapaSala.Formularios.Cadastros;
using MapaSala.Formularios.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Usuarios u = new Usuarios();
            dtUsuarios.DataSource = u.PreencherGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuário frm = new frmCadastrarUsuário();
            frm.FormClosed += FecharForm;
            frm.ShowDialog();
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Usuarios u = new Usuarios();
            dtUsuarios.DataSource = u.PreencherGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            dtUsuarios.DataSource = u.Pesquisar(txtPesquisar.Text);
        }

        private void dtUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtUsuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtUsuarios.Rows[e.RowIndex].Cells[0].Value);

                frmEditarUsuarios editar = new frmEditarUsuarios(id);

                // Inscreve-se no evento
                editar.FormClosed += FecharForm;
                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            dtUsuarios.DataSource = u.Pesquisar(txtPesquisar.Text);
        }
    }
}

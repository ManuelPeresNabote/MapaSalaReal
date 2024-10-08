using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Cadastros
{
    public partial class CadastroDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CadastroDisciplina()
        {
            InitializeComponent();
            string query = "select Id, Nome,Sigla,Ativo +from Disciplinas where Id=@id";
            Conexao.Open();
            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    txtNomeDisciplina.Text = Leitura[1].ToString();
                    txtSigla.Text = Leitura[2].ToString();
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[3]);

                }
            }
            Conexao.Close();
        }

        private void txtNomeDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            string query = "update Disciplinas set Nome = @nome, Sigla = @sigla, Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNomeDisciplina.Text = "";
            txtSigla.Text = "";
            chkAtivo.Checked = false;
        }
    }
}



        

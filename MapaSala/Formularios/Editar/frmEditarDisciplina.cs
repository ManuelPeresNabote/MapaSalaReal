﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Editar
{
    public partial class frmEditarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public frmEditarDisciplina(int DisciplinaId)
        {
            InitializeComponent();
            string query = "select Id, Nome,Sigla,Ativo +from Disciplinas where Id=@id";
            Conexao.Open();
            SqlCommand Comando = new SqlCommand(query, Conexao);
            Comando.Parameters.Add(new SqlParameter("@id", DisciplinaId));
            SqlDataReader Leitura = Comando.ExecuteReader();
            if (Leitura.HasRows) 
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
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
    }
    }

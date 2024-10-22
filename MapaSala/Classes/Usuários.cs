using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.Classes
{
    class Usuários
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public void Inserir()
        {
            Conexao.Open();
            string query = "insert into Usuários (Login, Senha, Ativo)" +
                "Values(@login, @senha, @ativo";

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro2 = new SqlParameter("@login", Login);
            SqlParameter parametro3 = new SqlParameter("@senha", Senha);
            SqlParameter parametro4 = new SqlParameter("@ativo", Ativo);
            

            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}

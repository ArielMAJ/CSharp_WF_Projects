using System;
using System.Data;
using System.Data.SQLite;


namespace Gestao
{
	 class Banco
	{
		private static SQLiteConnection conexao;

		private static SQLiteConnection ConexaoBanco()
        
			conexao = new DataConnection("Data Source=.\\DB\\gestao.db");
			conexao.Open();
			return conexao;

		}

		public static DataTable obterTodosUsuarios()
        {
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
            try
            {
				using (var cmd = ConexaoBanco().CreateCommand())
                {
					cmd.CommandText = "SELECT * FROM TB_USUARIOS";
					da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
					da.Fill(dt);
					return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
	}
}
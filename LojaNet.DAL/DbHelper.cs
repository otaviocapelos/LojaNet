using System.Data;
using System.Data.SqlClient;

namespace LojaNet.DAL
{
    public static class DbHelper
    {
        private static string conexao
        {
            get
            {
                return @"Data Source=(localDb)\MSSQLLocalDb;
                         Initial Catalog=LojaNetDb;
                         Integrated Security=true;";
            }
        }

        public static IDataReader ExecuteReader(string storedProcedure, params object[] parametros)
        {
            var con = new SqlConnection(conexao);
            var cmd = new SqlCommand(storedProcedure, con);
            PreencherParametros(parametros, cmd);
            con.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static int ExecuteNonQuery(string storedProcedure, params object[] parametros)
        {
            int retorno = 0;
            using (var con = new SqlConnection(conexao))
            {
                using (var cmd = new SqlCommand(storedProcedure, con))
                {
                    PreencherParametros(parametros, cmd);
                    con.Open();
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            return retorno;
        }

        private static void PreencherParametros(object[] parametros, SqlCommand cmd)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros.Length > 0)
            {
                for (int i = 0; i < parametros.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                }
            }
        }
    }
}

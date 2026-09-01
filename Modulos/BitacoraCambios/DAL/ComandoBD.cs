using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ComandoBD
    {
        private readonly string cadenaConexion;
        public ComandoBD()
        {
            cadenaConexion = "Data Source=.;Initial Catalog=bd_bitacoracambios;Integrated Security=True;Trust Server Certificate=True";
        }
        public DataTable Consultar(string sql, List<ParametroBD>? parametros = null)
        {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(cadenaConexion);
            using SqlCommand cmd = new SqlCommand(sql, con);
            ConfigurarComando(cmd, parametros);
            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }
        public int Ejecutar(string sql, List<ParametroBD>? parametros = null)
        {
            using SqlConnection con = new SqlConnection(cadenaConexion);
            using SqlCommand cmd = new SqlCommand(sql, con);
            ConfigurarComando(cmd, parametros);
            con.Open();
            return cmd.ExecuteNonQuery();
        }
        public object? Escalar(string sql, List<ParametroBD>? parametros = null)
        {
            using SqlConnection con = new SqlConnection(cadenaConexion);
            using SqlCommand cmd = new SqlCommand(sql, con);
            ConfigurarComando(cmd, parametros);
            con.Open();
            return cmd.ExecuteScalar();
        }

        private void ConfigurarComando(SqlCommand comando, List<ParametroBD>? parametros)
        {
            if (parametros != null)
            {
                foreach (ParametroBD p in parametros)
                {
                    comando.Parameters.Add(p.Nombre, p.Tipo).Value = p.Valor;
                }
            }
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace ISOF_InventaLey.Clases
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Gerente { get; set; }

        public static Departamento BuscaDepa(int depa)
        {
            Datos.Conectar();
            Departamento d = new Departamento();
            SqlDataReader dr;
            string cadena = $"Select id,nombre,gerente from Depas where id = '{depa}'";
            SqlCommand cmd = new SqlCommand(cadena, Datos.conx);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    d.Id = int.Parse(dr["id"].ToString());
                    d.Nombre = dr["nombre"].ToString();
                    d.Gerente = dr["gerente"].ToString();

                }
            }
            Datos.Desconectar();

            return d;
        }
        public static DataTable Buscar(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Datos.conx);
            da.Fill(dt);
            return dt;
        }
    }
}

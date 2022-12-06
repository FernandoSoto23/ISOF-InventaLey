using System.Data.SqlClient;

namespace ISOF_InventaLey.Clases
{
    class Datos
    {
        public static SqlConnection conx = new SqlConnection();
        public static void Conectar()
        {
            conx.ConnectionString = "server = .\\;database = inventaley;user id = sa;password = fernando1234";
            conx.Open();

        }

        public static void Desconectar()
        {
            if (conx != null && conx.State == System.Data.ConnectionState.Open)
                conx.Close();
        }
    }
}

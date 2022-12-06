using System.Data.SqlClient;

namespace ISOF_InventaLey.Clases
{
    public class Loguear
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public static bool Login(Loguear u)
        {
            Datos.Conectar();
            bool s = false;
            string cadena = $"Select * from usuarios where [user] = '{u.Usuario}' and pwd = '{u.Contraseña}'";
            SqlCommand cmd = new SqlCommand(cadena, Datos.conx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                s = true;
            }
            Datos.Desconectar();
            return s;
        }
    }
}

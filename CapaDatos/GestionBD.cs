using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos.Catalogos;

namespace CapaDatos
{
    public class GestionBD
    {
        SqlConnection conexion;
        SqlCommand cmd;

        public void inserts(Herramientas herramientas) {
            conexion = new SqlConnection();
            cmd = new SqlCommand();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            conexion.Open();
            cmd.CommandText = "Insert into Herramientas(Nombre_Producto,Tipo_Herramienta,DescUbicacion,Cantidad)" + 
                              "VALUES (@Nombre_Producto, @Tipo_Herramienta,@DescUbicacion,@Cantidad)";
            cmd.CommandType = System.Data.CommandType.Text;

            SqlParameter objParametro = new SqlParameter();
            cmd.Parameters.Add(objParametro);
            cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", herramientas.Producto));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Herramienta", herramientas.TProducto));
            cmd.Parameters.Add(new SqlParameter("@DescUbicacion", herramientas.Ubicacion));
            cmd.Parameters.Add(new SqlParameter("@Cantidad", herramientas.cant));
        }
        public void jalar() {
            conexion = new SqlConnection();
            cmd = new SqlCommand();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            conexion.Open();
            cmd.CommandText = "Select * from Herramientas";
            cmd.CommandType = System.Data.CommandType.Text;
        }
    }
}

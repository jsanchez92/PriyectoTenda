using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tienda.Controllers
{
    internal class CFabricante : IBuilder<MFabricante>
    {
        public string Add(MFabricante data)
        {
            string respuesta = string.Empty;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Utils.Connexion.Cn;
            SqlCommand Cmd = new SqlCommand();
            try
            {
                sqlCon.Open();
                Cmd.CommandText = "insert into fabricante (nombre) values(@Nombre)";
                Cmd.CommandType = CommandType.Text;

                Cmd.Connection = sqlCon;
                Cmd.Parameters.AddWithValue("@Nombre", data.Nombre);
                Cmd.ExecuteNonQuery();
                respuesta = "Ok";
                sqlCon.Dispose();

            }
            catch (SqlException Ex)
            {
                respuesta = Ex.Message;
            }
            return respuesta;
        }

        public string Delete(int id)
        {
            string respuesta = string.Empty;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Utils.Connexion.Cn;
            SqlCommand Cmd = new SqlCommand();
            try
            {
                sqlCon.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "delete fabricante where id = @Id";
                Cmd.CommandType = CommandType.Text;

                Cmd.Connection = sqlCon;
                Cmd.Parameters.AddWithValue("@Id", id);
                Cmd.ExecuteNonQuery();
                respuesta = "Ok";
                sqlCon.Dispose();

            }
            catch (SqlException Ex)
            {
                respuesta = Ex.Message;
            }
            return respuesta;
        }

        public DataTable Show(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Utils.Connexion.Cn;
            SqlCommand Cmd = new SqlCommand();
            try
            {
                sqlCon.Open();
                Cmd.CommandText = "select * from fabricante where nombre like '%' + @Nombre +'%'";
                Cmd.CommandType= CommandType.Text;

                Cmd.Connection = sqlCon;
                Cmd.Parameters.AddWithValue("@Nombre", searchText);

                SqlDataAdapter SqlDt = new SqlDataAdapter(Cmd);
                SqlDt.Fill(dt);
                sqlCon.Dispose ();
                
            }
            catch (Exception)
            {

                throw;
            } 
            return dt;
        }

        public string Update(MFabricante data)
        {
            string respuesta = string.Empty;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Utils.Connexion.Cn;
            SqlCommand Cmd = new SqlCommand();
            try
            {
                sqlCon.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "Update fabricante set nombre =@Nombre where id = @Id";
                Cmd.CommandType = CommandType.Text;

                Cmd.Connection = sqlCon;
                Cmd.Parameters.AddWithValue("@Id", data.Id);
                Cmd.Parameters.AddWithValue("@Nombre", data.Nombre);
                Cmd.ExecuteNonQuery();
                respuesta = "Ok";
                sqlCon.Dispose();

            }
            catch (SqlException Ex)
            {
                respuesta = Ex.Message;
            }
            return respuesta;
        }
    }
}

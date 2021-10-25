using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Models;
using System.Data;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
        public static List<Publisher> Listar()
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    });
            }
            AdminDB.conectarBase().Close();
            reader.Close();
            return lista;
        }
        public static List<Publisher> Listar(string City)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());
            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = City;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    });
            }
            AdminDB.conectarBase().Close();
            reader.Close();
            return lista;
        }
        public static List<Publisher> Listar(string City, string State)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city AND state=@state";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());
            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = City;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = State;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    });
            }
            AdminDB.conectarBase().Close();
            reader.Close();
            return lista;
        }
        public static List<Publisher> Listar(string City, string State, string Country)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city AND state=@state AND country =@country";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());
            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = City;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = State;
            comando.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = Country;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    });
            }
            AdminDB.conectarBase().Close();
            reader.Close();
            return lista;
        }
    }
}

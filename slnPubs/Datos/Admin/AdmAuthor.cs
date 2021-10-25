using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> listar(string ciudad, string estado)
        {
            List<Author> autores = new List<Author>();
            string consultaSQL = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.authors WHERE city = @city AND state is null OR state = @state";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar).Value = ciudad;
            comando.Parameters.Add("@state", SqlDbType.VarChar).Value = estado;

            return leer(autores, comando);
        }

        public static List<Author> listar(string ciudad)
        {
            List<Author> autores = new List<Author>();
            string consultaSQL = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.authors WHERE city = @city";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar).Value = ciudad;

            return leer(autores, comando);
        }
        public static List<Author> listar()
        {
            List<Author> autores = new List<Author>();
            string consultaSQL = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.authors";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                autores.Add
                    (
                        new Author
                        (
                            Convert.ToString(reader["au_id"]),
                            Convert.ToString(reader["au_lname"]),
                            Convert.ToString(reader["au_fname"]),
                            Convert.ToString(reader["phone"]),
                            Convert.ToString(reader["address"]),
                            Convert.ToString(reader["city"]),
                            Convert.ToString(reader["state"]),
                            Convert.ToString(reader["zip"]),
                            Convert.ToBoolean(reader["contract"])
                        )
                    );
            }
            AdminDB.connection.Close();
            reader.Close();
            return autores;
        }
        private static List<Author> leer(List<Author> autores, SqlCommand comando)
        {
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                autores.Add
                    (
                        new Author
                        (
                            Convert.ToString(reader["au_id"]),
                            Convert.ToString(reader["au_lname"]),
                            Convert.ToString(reader["au_fname"]),
                            Convert.ToString(reader["phone"]),
                            Convert.ToString(reader["address"]),
                            Convert.ToString(reader["city"]),
                            Convert.ToString(reader["state"]),
                            Convert.ToString(reader["zip"]),
                            Convert.ToBoolean(reader["contract"])
                        )
                    );
            }
            AdminDB.connection.Close();
            reader.Close();
            return autores;
        }
            public static DataTable listarPorCiudad(string city)
            {
                // query
                string consultaSQL = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.authors WHERE city = @city";
            SqlConnection connection = AdminDB.conectarBase();
            // declarar y crear un SQLDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, connection);

                // declarar parámetros
                adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;

                // declarar y crear un DataSet
                DataSet dataSet = new DataSet();

                // invocar al método Fill --> conecta a la base, ejecuta el SELECT, crea el DataTable y se desconecta
                adapter.Fill(dataSet, "city");
            connection.Close();
            // devolver la tabla por índice o nombre (recomendado)
            return dataSet.Tables["city"];
        }
        public static DataTable listarCiudades()
        {
            // query
            string consultaSQL = "SELECT DISTINCT city FROM dbo.authors";

            SqlConnection connection = AdminDB.conectarBase();
            // declarar y crear un SQLDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, connection);

            // declarar y crear un DataSet
            DataSet dataSet = new DataSet();

            // invocar al método Fill --> conecta a la base, ejecuta el SELECT, crea el DataTable y se desconecta
            adapter.Fill(dataSet, "city");
            connection.Close();
            // devolver la tabla por índice o nombre (recomendado)
            return dataSet.Tables["city"];
        }
    }
}
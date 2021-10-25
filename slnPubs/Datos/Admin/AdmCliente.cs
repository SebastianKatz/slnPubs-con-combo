using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using System.Data.SqlClient;
////using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdmCliente
    {
        public static DataTable Listar()
        {
            //TODO falta implementar Listar
            // devuelve todos los clientes en data table
            return null;
        }
        //public static int Insertar(Cliente cliente)
        //{
        //    string inserSQL = "INSERT dbo.Cliente (Nombre,Apellido,FechaNacimiento) VALUES(@Nombre,@Apellido,@FechaNacimiento)";
        //    SqlCommand command = new SqlCommand(inserSQL, AdminDB.ConectarBase());
        //    command.Parameters.Add("@Nombre", sqlDbType.VarChar, 50).Value = cliente.Nombre;
        //    command.Parameters.Add("@Apellido", sqlDbType.VarChar, 50).Value = cliente.Apellido;
        //    command.Parameters.Add("@FechaNacimiento", sqlDbType.Date).Value = cliente.FechaNacimiento;

        //    int filasAfectadas = command.ExecuteNonQuery();

        //    AdminDB.ConectarBase().Close();
        //    return 0;
        //}
    }
}

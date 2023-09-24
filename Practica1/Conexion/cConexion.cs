using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Conexion
{
    public class cConexion
    {
        public SqlConnection con;
        private string Server { get; set; }
        private string BaseDeDatos { get; set; }
        private string Usuario { get; set; }
        private string Clave { get; set; }
        public cConexion()
        {
            Server = ".";
            BaseDeDatos = "Prueba";
            Usuario = "sa";
            Clave = "1405";
            con = new SqlConnection();
            con.ConnectionString = "Server=" + "." + ";DataBase=" + BaseDeDatos
                + ";User id=" + Usuario + ";Password=" + Clave;
        }
        public bool abrirCerrarConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            return true;
        }
        public void AbrirConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }

        }
        public void CerrarConexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                con.Close();
            }
            else
            {
                con.Close();
            }
        }
    }
}

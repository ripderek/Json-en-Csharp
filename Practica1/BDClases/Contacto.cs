using Practica1.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.BDClases
{
    public class Contacto
    {
        //variable para la conexion a la base de datos
        cConexion conexion = new cConexion();

        //crear una funcion para enviar a la base de datos a insertar los datos
        public Contacto(string Json_Datos) {
            //aqui enviar a insertar los datos
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("InsertarDatosDesdeJSONTodosTablas", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@jsonDatos", Json_Datos);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                //MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Console.WriteLine("Se guardaron los datos en la BD");
            }
            catch (Exception n)
            {
                //MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Console.WriteLine("Error:"+n.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase.Properties;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        // Esta línea conecta con tu base de datos
        private static string cnn = Settings.Default.opticaConnectionString;

        // 1. LISTAR TODOS LOS USUARIOS (Esto soluciona tu error de la línea roja)
        public static DataTable list_usuarios()
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 2. LISTAR ROLES (Para cargar tu ComboBox)
        public static DataTable list_roles()
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Roles", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 3. BUSCAR (El requisito del LIKE)
        public static DataTable search_usuarios(string patron)
        {
            SqlConnection conn = new SqlConnection(cnn);
            string query = "SELECT * FROM Usuario WHERE Usu_NombreUsuario LIKE @patron";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@patron", "%" + patron + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 4. ALTA (Insert)
        public static void insert_usuario(Usuario user)
        {
            SqlConnection conn = new SqlConnection(cnn);
            string query = "INSERT INTO Usuario (Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo) VALUES (@u, @p, @n, @r)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@p", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@n", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@r", user.Rol_Codigo);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // 5. MODIFICACIÓN (Update)
        public static void update_usuario(Usuario user)
        {
            SqlConnection conn = new SqlConnection(cnn);
            string query = "UPDATE Usuario SET Usu_NombreUsuario = @u, Usu_Contraseña = @p, Usu_ApellidoNombre = @n, Rol_Codigo = @r WHERE Usu_ID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@p", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@n", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@r", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@id", user.Usu_ID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // 6. BAJA (Delete)
        public static void delete_usuario(int id)
        {
            SqlConnection conn = new SqlConnection(cnn);
            string query = "DELETE FROM Usuario WHERE Usu_ID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
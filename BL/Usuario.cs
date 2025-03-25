using DL_EF;
using ML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        /*public static void AddSQLClient(ML.Usuario usuario)
        {
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "INSERT INTO Usuario VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @edad)";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;

                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellidoPaterno", usuario.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@apellidoMaterno", usuario.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@edad", usuario.Edad);

                    context.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("EL registro se inserto de manera correcta");
                    }
                    else
                    {
                        Console.WriteLine("Error al insertar");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión");
            }
        }*/

        /*public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UsuarioAdd";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", usuario.UserName);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Password", usuario.Password);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Estatus", usuario.Estatus);
                    cmd.Parameters.AddWithValue("@CURP", usuario.CURP);
                    //cmd.Parameters.AddWithValue("@Imagen", usuario.Imagen);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);

                    context.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo insertar el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                //HUBO UN ERROR
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }*/

        /*public static void DeleteSQLClient(int idUsuario)
        {
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "DELETE FROM Usuario WHERE IdUsuario=@idUsuario";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    context.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("EL registro se elimino de manera correcta");
                    }
                    else
                    {
                        Console.WriteLine("Error al eliminar");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión");
            }
        }*/

        /*public static ML.Result Delete(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UsuarioDelete";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    context.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo eliminar el registro";
                    }

                }

            }
            catch (Exception ex)
            {
                //HUBO UN ERROR
                //no hay registros
                result.Correct = false;
                result.ErrorMessage = "No hay datos/registros";
            }

            return result;
        }*/

        /*public static void UpdateSQLClient(ML.Usuario usuario)
        {
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UPDATE Usuario SET Nombre = @nombre, ApellidoPaterno = @apellidoPaterno, ApellidoMaterno = @apellidoMaterno, Edad=@edad WHERE IdUsuario = @idUsuario;";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;

                    cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario); 
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellidoPaterno", usuario.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@apellidoMaterno", usuario.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@edad", usuario.Edad);

                    context.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("EL registro se actualizo de manera correcta");
                    }
                    else
                    {
                        Console.WriteLine("Error al actualizar");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión");
            }
        }*/

        /*public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UsuarioUpdate";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@UserName", usuario.UserName);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Password", usuario.Password);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Estatus", usuario.Estatus);
                    cmd.Parameters.AddWithValue("@CURP", usuario.CURP);
                    //cmd.Parameters.AddWithValue("@Imagen", usuario.Imagen);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);

                    context.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                //HUBO UN ERROR
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }*/

        /*public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UsuarioGetAll";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        //si trae registros
                        result.Objects = new List<object>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = Convert.ToInt32(row[0].ToString());
                            usuario.UserName = row[1].ToString();
                            usuario.Nombre = row[2].ToString();
                            usuario.ApellidoPaterno = row[3].ToString();
                            usuario.ApellidoMaterno = row[4].ToString();
                            usuario.Email = row[5].ToString();
                            usuario.Password = row[6].ToString();
                            //Ver date 
                            usuario.FechaNacimiento = row[7].ToString();
                            usuario.Sexo = row[8].ToString();
                            usuario.Telefono = row[9].ToString();
                            usuario.Celular = row[10].ToString();
                            usuario.Estatus = Convert.ToBoolean(row[11].ToString());
                            usuario.CURP = row[12].ToString();
                            //revisar sig linea
                            // usuario.Imagen = Convert.ToByte(row[13].ToString());
                            usuario.IdRol = Convert.ToInt32(row[13].ToString());

                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;

                    }
                    else
                    {
                        //no hay registros
                        result.Correct = false;
                        result.ErrorMessage = "No hay datos/registros";
                    }

                }

            }
            catch (Exception ex)
            {
                //HUBO UN ERROR
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }*/

        /*public static ML.Result GetById(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Connection.GetConnection()))
                {
                    string query = "UsuarioGetById";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        //si trae registros
                        DataRow row = dataTable.Rows[0];
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = Convert.ToInt32(row[0].ToString());
                        usuario.UserName = row[1].ToString();
                        usuario.Nombre = row[2].ToString();
                        usuario.ApellidoPaterno = row[3].ToString();
                        usuario.ApellidoMaterno = row[4].ToString();
                        usuario.Email = row[5].ToString();
                        usuario.Password = row[6].ToString();
                        usuario.FechaNacimiento = row[7].ToString();
                        usuario.Sexo = row[8].ToString();
                        usuario.Telefono = row[9].ToString();
                        usuario.Celular = row[10].ToString();
                        usuario.Estatus = Convert.ToBoolean(row[11].ToString());
                        usuario.CURP = row[12].ToString();
                        //revisar sig linea
                        // usuario.Imagen = Convert.ToByte(row[13].ToString());
                        usuario.IdRol = Convert.ToInt32(row[13].ToString());

                        result.Object = usuario; //BOXING
                        result.Correct = true;
                    }
                    else
                    {
                        //no hay registros
                        result.Correct = false;
                        result.ErrorMessage = "No hay datos/registros";
                    }

                }

            }
            catch (Exception ex)
            {
                //HUBO UN ERROR
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }*/

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context = new
                    DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    int rowsAffect = context.UsuarioAdd(usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Email, usuario.Password, DateTime.Parse(usuario.FechaNacimiento.ToString()),
                        usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.Estatus, usuario.CURP, usuario.Imagen,
                        usuario.Rol.IdRol, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia);
                    if (rowsAffect > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo insertar el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context = new
                    DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    int rowsAffect = context.UsuarioUpdate(usuario.IdUsuario, usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Email, usuario.Password, DateTime.Parse(usuario.FechaNacimiento.ToString()),
                        usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.Estatus, usuario.CURP, usuario.Imagen,
                        usuario.Rol.IdRol, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia);
                    if (rowsAffect > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result DeleteEF(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context = new
                    DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    int rowsAffect = context.UsuarioDelete(idUsuario);
                    if (rowsAffect > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo eliminar el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAllEF(ML.Usuario usuarioObj)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
                    new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    var query = context.UsuarioGetAll(usuarioObj.Nombre, usuarioObj.ApellidoPaterno, usuarioObj.ApellidoMaterno, usuarioObj.Rol.IdRol).ToList();
                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var objBD in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol(); //abrir la puerta para ir a ROL
                            usuario.Direccion = new ML.Direccion(); //SE ABRIO LA PUERTA A DIRECCION
                            usuario.Direccion.Colonia = new ML.Colonia(); //SE ABRIO LA PUERTA A COLONIA
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio(); //SE ABRIO LA PUERTA A MUNICIPIO
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado(); //SE ABRIO LA PUERTA A ESTADO
                            usuario.IdUsuario = objBD.IdUsuario;
                            usuario.UserName = objBD.UserName;
                            usuario.Nombre = objBD.NombreUsuario;
                            usuario.ApellidoPaterno = objBD.ApellidoPaterno;
                            usuario.ApellidoMaterno = objBD.ApellidoMaterno;
                            usuario.Email = objBD.Email;
                            usuario.Password = objBD.Password;
                            usuario.FechaNacimiento = objBD.FechaNacimiento;
                            usuario.Sexo = objBD.Sexo;
                            usuario.Telefono = objBD.Telefono;
                            usuario.Celular = objBD.Celular;
                            usuario.Estatus = objBD.Estatus;
                            usuario.CURP = objBD.CURP;
                            usuario.Imagen = objBD.Imagen;
                            if(objBD.Imagen!=null)
                            {
                                usuario.ImagenBase64 = Convert.ToBase64String(objBD.Imagen);
                            }
                            else
                            {
                                usuario.ImagenBase64 = null;
                            }
                            usuario.Imagen = objBD.Imagen;
                            usuario.Rol.Nombre = objBD.NombreRol;
                            usuario.Direccion.Calle = objBD.Calle;
                            usuario.Direccion.NumeroExterior = objBD.NumeroExterior;
                            usuario.Direccion.NumeroInterior = objBD.NumeroInterior;
                            usuario.Direccion.Colonia.Nombre = objBD.NombreColonia;
                            usuario.Direccion.Colonia.CodigoPostal = objBD.CodigoPostal;
                            usuario.Direccion.Colonia.Municipio.Nombre = objBD.NombreMunicipio;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = objBD.NombreEstado;

                            result.Objects.Add(usuario);
                            result.Correct = true;
                        }
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay registros";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }
        
        public static ML.Result GetByIdEF(int idUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
                    new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    var query = context.UsuarioGetById(idUsuario).SingleOrDefault();
                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Rol = new ML.Rol(); //abrir la puerta para ir a ROL
                        usuario.Direccion = new ML.Direccion(); //SE ABRIO LA PUERTA A DIRECCION
                        usuario.Direccion.Colonia = new ML.Colonia(); //SE ABRIO LA PUERTA A COLONIA
                        usuario.Direccion.Colonia.Municipio = new ML.Municipio(); //SE ABRIO LA PUERTA A MUNICIPIO
                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado(); //SE ABRIO LA PUERTA A ESTADO

                        usuario.IdUsuario = query.IdUsuario;
                        usuario.UserName = query.UserName;
                        usuario.Nombre = query.NombreUsuario;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Email = query.Email;
                        usuario.Password = query.Password;
                        usuario.FechaNacimiento = query.FechaNacimiento;
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.Estatus = query.Estatus;
                        usuario.CURP = query.CURP;
                        usuario.Imagen = query.Imagen;
                        if (query.IdRol != null)
                        {
                            //trae un id 
                            usuario.Rol.IdRol = query.IdRol.Value;
                        }
                        else
                        {
                            usuario.Rol.IdRol = 0;

                        }
                        if (query.IdDireccion != null)
                        {
                            usuario.Direccion.IdDireccion = query.IdDireccion.Value;
                        }
                        else
                        {
                            usuario.Direccion.Colonia.IdColonia = 0;
                        }
                        usuario.Direccion.Calle = query.Calle;
                        usuario.Direccion.NumeroExterior = query.NumeroExterior;
                        usuario.Direccion.NumeroInterior = query.NumeroInterior;
                        if (query.IdColonia != null)
                        {
                            usuario.Direccion.Colonia.IdColonia = query.IdColonia.Value;
                        }
                        else
                        {
                            usuario.Direccion.Colonia.IdColonia = 0;
                        }
                        usuario.Direccion.Colonia.CodigoPostal = query.CodigoPostal;
                        if (query.IdMunicipio != null)
                        {
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio.Value;
                        }
                        else
                        {
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = 0;
                        }
                        if (query.IdEstado != null)
                        {
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado.Value;

                        }
                        else
                        {
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = 0;
                        }


                        result.Object = usuario; //BOXING
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No existe el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result CambiarEstatus(int Usuario, bool Estatus)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context = new
                    DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
                {
                    int rowsAffect = context.CambioEstatus(Usuario, Estatus);
                    if (rowsAffect > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar el estatus";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        //public static ML.Result AddLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
        //        new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
        //        {
        //            DL_EF.Usuario usuarioBD = new DL_EF.Usuario();
        //            usuarioBD.Nombre = usuario.Nombre;
        //            usuarioBD.UserName = usuario.UserName;
        //            usuarioBD.Nombre = usuario.Nombre;
        //            usuarioBD.ApellidoPaterno = usuario.ApellidoPaterno;
        //            usuarioBD.ApellidoMaterno = usuario.ApellidoMaterno;
        //            usuarioBD.Email = usuario.Email;
        //            usuarioBD.Password = usuario.Password;
        //            usuarioBD.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento.ToString());
        //            usuarioBD.Sexo = usuario.Sexo;
        //            usuarioBD.Telefono = usuario.Telefono;
        //            usuarioBD.Celular = usuario.Celular;
        //            usuarioBD.Estatus = usuario.Estatus;
        //            usuarioBD.CURP = usuario.CURP;
        //            usuarioBD.IdRol = usuario.IdRol;

        //            context.Usuarios.Add(usuarioBD);

        //            int filasAfectadas = context.SaveChanges();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al insertar";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
        //public static ML.Result DeleteLINQ(int idUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
        //            new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
        //        {
        //            //Primero se busca con un select
        //            var query = (from usuario in context.Usuarios
        //                         where usuario.IdUsuario == idUsuario
        //                         select usuario).SingleOrDefault();

        //            if (query != null)
        //            {
        //                context.Usuarios.Remove(query); //aqui se genera el delete
        //                int filasAfectadas = context.SaveChanges();

        //                if (filasAfectadas > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "No se pudo eliminar";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result UpdateLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
        //            new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
        //        {

        //            //Primero se busca con un select
        //            var query = (from usuarioSelect in context.Usuarios
        //                         where usuarioSelect.IdUsuario == usuario.IdUsuario
        //                         select usuarioSelect).SingleOrDefault();

        //            if (query != null)
        //            {
        //                query.IdUsuario = usuario.IdUsuario;
        //                query.Nombre = usuario.Nombre;
        //                query.UserName = usuario.UserName;
        //                query.Nombre = usuario.Nombre;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.Email = usuario.Email;
        //                query.Password = usuario.Password;
        //                query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento.ToString());
        //                query.Sexo = usuario.Sexo;
        //                query.Telefono = usuario.Telefono;
        //                query.Celular = usuario.Celular;
        //                query.Estatus = usuario.Estatus;
        //                query.CURP = usuario.CURP;
        //                query.IdRol = usuario.IdRol;

        //                int filasAfectadas = context.SaveChanges();

        //                if (filasAfectadas > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Error al actualizar";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAllLINQ()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
        //            new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
        //        {

        //            //Primero se busca con un select
        //            var query = (from usuarioDB in context.Usuarios
        //                         select new
        //                         {
        //                             IdUsuario = usuarioDB.IdUsuario,
        //                             UserName = usuarioDB.UserName,
        //                             Nombre = usuarioDB.Nombre,
        //                             ApellidoPaterno = usuarioDB.ApellidoPaterno,
        //                             ApellidoMaterno = usuarioDB.ApellidoMaterno,
        //                             Email = usuarioDB.Email,
        //                             Password = usuarioDB.Password,
        //                             FechaNacimiento = usuarioDB.FechaNacimiento,
        //                             Sexo = usuarioDB.Sexo,
        //                             Telefono = usuarioDB.Telefono,
        //                             Celular = usuarioDB.Celular,
        //                             Estatus = usuarioDB.Estatus,
        //                             CURP = usuarioDB.CURP,
        //                             IdRol = usuarioDB.IdRol

        //                         }).ToList();

        //            if (query.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (var objBD in query)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = objBD.IdUsuario;
        //                    usuario.UserName = objBD.UserName;
        //                    usuario.Nombre = objBD.Nombre;
        //                    usuario.ApellidoPaterno = objBD.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = objBD.ApellidoMaterno;
        //                    usuario.Email = objBD.Email;
        //                    usuario.Password = objBD.Password;
        //                    usuario.FechaNacimiento = objBD.FechaNacimiento.ToString(("dd/MM/yyyy"));
        //                    usuario.Sexo = objBD.Sexo;
        //                    usuario.Telefono = objBD.Telefono;
        //                    usuario.Celular = objBD.Celular;
        //                    usuario.Estatus = objBD.Estatus;
        //                    usuario.CURP = objBD.CURP;
        //                    if (objBD.IdRol == null)
        //                    {
        //                        usuario.IdRol = 0;
        //                    }
        //                    else
        //                    {
        //                        usuario.IdRol = objBD.IdRol.Value;
        //                    }

        //                    result.Objects.Add(usuario);
        //                    result.Correct = true;
        //                }
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No hay registros";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result GetByIdLINQ(int idUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.AMoralesProgramacionNCapasUsuariosEntities context =
        //            new DL_EF.AMoralesProgramacionNCapasUsuariosEntities())
        //        {

        //            //Primero se busca con un select
        //            var query = (from usuarioDB in context.Usuarios
        //                         where usuarioDB.IdUsuario == idUsuario
        //                         select new
        //                         {
        //                             IdUsuario = usuarioDB.IdUsuario,
        //                             UserName = usuarioDB.UserName,
        //                             Nombre = usuarioDB.Nombre,
        //                             ApellidoPaterno = usuarioDB.ApellidoPaterno,
        //                             ApellidoMaterno = usuarioDB.ApellidoMaterno,
        //                             Email = usuarioDB.Email,
        //                             Password = usuarioDB.Password,
        //                             FechaNacimiento = usuarioDB.FechaNacimiento,
        //                             Sexo = usuarioDB.Sexo,
        //                             Telefono = usuarioDB.Telefono,
        //                             Celular = usuarioDB.Celular,
        //                             Estatus = usuarioDB.Estatus,
        //                             CURP = usuarioDB.CURP,
        //                             IdRol = usuarioDB.IdRol

        //                         }).SingleOrDefault();


        //            if (query != null)
        //            {
        //                ML.Usuario usuario = new ML.Usuario();
        //                usuario.IdUsuario = query.IdUsuario;
        //                usuario.UserName = query.UserName;
        //                usuario.Nombre = query.Nombre;
        //                usuario.ApellidoPaterno = query.ApellidoPaterno;
        //                usuario.ApellidoMaterno = query.ApellidoMaterno;
        //                usuario.Email = query.Email;
        //                usuario.Password = query.Password;
        //                usuario.FechaNacimiento = query.FechaNacimiento.ToString(("dd/MM/yyyy"));
        //                usuario.Sexo = query.Sexo;
        //                usuario.Telefono = query.Telefono;
        //                usuario.Celular = query.Celular;
        //                usuario.Estatus = query.Estatus;
        //                usuario.CURP = query.CURP;
        //                if (query.IdRol == null)
        //                {
        //                    usuario.IdRol = 0;
        //                }
        //                else
        //                {
        //                    usuario.IdRol = query.IdRol.Value;
        //                }

        //                result.Object = usuario; //BOXING
        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No hay registro";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        public static ML.Result CargaMasiva()
        {
            ML.Result result = new ML.Result();
            string ruta = @"C:\Users\digis\Downloads\CargaMasiva.txt";
            try
            {
                StreamReader streamReader = new StreamReader(ruta);
                string fila = "";

                streamReader.ReadLine();

                while ((fila = streamReader.ReadLine()) != null)
                {
                    string[] valores = fila.Split('|');

                    ML.Usuario usuario = new ML.Usuario();
                    usuario.UserName = valores[0];
                    usuario.Nombre = valores[1];
                    usuario.ApellidoPaterno = valores[2];
                    usuario.ApellidoMaterno = valores[3];
                    usuario.Nombre = valores[4];


                    BL.Usuario.AddEF(usuario);
                    result.Correct = true;
                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result LeerExcel(string cadenaConexion)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (OleDbConnection context = new OleDbConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        OleDbDataAdapter adapter = new OleDbDataAdapter();
                        adapter.SelectCommand = cmd;

                        DataTable tablaUsuario = new DataTable();
                        adapter.Fill(tablaUsuario);

                        if (tablaUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in tablaUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.Rol = new ML.Rol();
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.UserName = row[0].ToString();
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Email = row[4].ToString();
                                usuario.Password = row[5].ToString();
                                usuario.FechaNacimiento = row[6].ToString();
                                usuario.Sexo = row[7].ToString();
                                usuario.Telefono = row[8].ToString();
                                usuario.Celular = row[9].ToString();
                                //usuario.Estatus = Convert.ToBoolean(row[10].ToString());
                                usuario.CURP = row[10].ToString();
                                usuario.Imagen = null;
                                if (row[11] == DBNull.Value || string.IsNullOrEmpty(row[11].ToString()))
                                {
                                    usuario.Rol.IdRol = 0;
                                }
                                else
                                {
                                    usuario.Rol.IdRol = Convert.ToInt16(row[11]);
                                }
                                usuario.Direccion.Calle = row[12].ToString();
                                usuario.Direccion.NumeroExterior = row[13].ToString();
                                usuario.Direccion.NumeroInterior = row[14].ToString();
                                if (row[15] == DBNull.Value || string.IsNullOrEmpty(row[15].ToString()))
                                {
                                    usuario.Direccion.Colonia.IdColonia = 0;
                                }
                                else
                                {
                                    usuario.Direccion.Colonia.IdColonia = Convert.ToInt16(row[15]);
                                }
                                
                                result.Objects.Add(usuario);

                            }
                            result.Correct = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }

        public static ML.ResultExcel ValidarExcel(List<object> registros)
        {
            ML.ResultExcel result = new ML.ResultExcel();
            result.Errores = new List<object>();

            int contador = 1;

            foreach (ML.Usuario usuario in registros)
            {
                ML.ResultExcel resultValidacion = new ML.ResultExcel();

                resultValidacion.NumeroRegistro = contador;

                if (usuario.UserName.Length > 50 || usuario.UserName == "" || usuario.UserName == null)
                {
                    resultValidacion.ErrorMessage += "La columna username (A" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Nombre.Length > 50 || usuario.Nombre == "" || usuario.Nombre == null)
                {
                    resultValidacion.ErrorMessage += "La columna nombre (B" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.ApellidoPaterno.Length > 50 || usuario.ApellidoPaterno == "" || usuario.ApellidoPaterno == null)
                {
                    resultValidacion.ErrorMessage += "La columna apellido paterno (C" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.ApellidoMaterno.Length > 50 || usuario.ApellidoMaterno == "" || usuario.ApellidoMaterno == null)
                {
                    resultValidacion.ErrorMessage += "La columna apellido materno (D" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Email.Length > 254 || usuario.Email == "" || usuario.Email == null)
                {
                    resultValidacion.ErrorMessage += "La columna email (E" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Password.Length > 50 || usuario.Password == "" || usuario.Password == null)
                {
                    resultValidacion.ErrorMessage += "La columna password (F" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.FechaNacimiento.Length > 50 || usuario.FechaNacimiento == "" || usuario.FechaNacimiento == null)
                {
                    resultValidacion.ErrorMessage += "La columna fecha de nacimiento (G" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Sexo.Length > 2 || usuario.Sexo == "" || usuario.Sexo == null)
                {
                    resultValidacion.ErrorMessage += "La columna sexo (H" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Telefono.Length > 20 || usuario.Telefono == "" || usuario.Telefono == null)
                {
                    resultValidacion.ErrorMessage += " \n La columna telefono (I" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Celular.Length > 20 || usuario.Celular == "" || usuario.Celular == null)
                {
                    resultValidacion.ErrorMessage += "La columna celular (J" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.CURP.Length > 50 || usuario.CURP == "" || usuario.CURP == null)
                {
                    resultValidacion.ErrorMessage += "La columna CURP (K" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Rol.IdRol == 0 || usuario.Rol.IdRol == null)
                {
                    resultValidacion.ErrorMessage += " La columna Id rol (L" + (contador + 1) + ") tiene un error porque es vacía o es igual a cero. ";
                }

                if (usuario.Direccion.Calle.Length > 50 || usuario.Direccion.Calle == "" || usuario.Direccion.Calle == null)
                {
                    resultValidacion.ErrorMessage += "La columna calle (M" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Direccion.NumeroInterior.Length > 20 || usuario.Direccion.NumeroInterior == "" || usuario.Direccion.NumeroInterior == null)
                {
                    resultValidacion.ErrorMessage += "La columna numero interior (N" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Direccion.NumeroExterior.Length > 20 || usuario.Direccion.NumeroExterior == "" || usuario.Direccion.NumeroExterior == null)
                {
                    resultValidacion.ErrorMessage += "La columna numero exterior (O" + (contador + 1) + ") tiene un error porque excede el número de caracteres permitidos o es vacía. ";
                }

                if (usuario.Direccion.Colonia.IdColonia == 0 || usuario.Direccion.Colonia.IdColonia == null)
                {
                    resultValidacion.ErrorMessage += "La columna Id colonia (P" + (contador + 1) + ") tiene un error porque es vacía o es igual a cero. ";
                }

                if (resultValidacion.ErrorMessage != null)
                {
                    result.Errores.Add(resultValidacion);
                }

                contador++;
            }

            return result;
        }
    }

}


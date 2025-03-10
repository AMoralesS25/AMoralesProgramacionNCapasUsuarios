using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Opcion()
        {
            Console.WriteLine("Ingresa el numero dependiendo de la accion que quieres realizar" +
                "\n1  Insertar" + "\n2  Eliminar" + "\n3  Actualizar" + "\n4  Consultar" +
                "\n5  Consultar por ID\n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Usuario.Add();
                    break;
                case 2:
                    Usuario.Delete();
                    break;
                case 3:
                    Usuario.Update();
                    break;
                case 4:
                    Usuario.GetAll();
                    break;
                case 5:
                    //Usuario.GetById();
                    break;
                default:
                    Console.WriteLine("No elegiste una opcion");
                    break;
            }
        }
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el nombre de usuario");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingresa la contraseña");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento dd/mm/yyyy");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingresa el sexo");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa el estatus");
            usuario.Estatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingresa el CURP");
            usuario.CURP = Console.ReadLine();
            //Console.WriteLine("Ingresa la imagen");
            //usuario.Imagen = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingresa el IdRol");
            //usuario.IdRol = Convert.ToInt32(Console.ReadLine());

            //BL.Usuario.AddLINQ(usuario);
            //mandar esta informacion => BL a traves de ML de Usuario
        }
        public static void Delete()
        {
            Console.WriteLine("Ingresa el ID del usuario para eliminar");
            int idUsuario = Convert.ToInt32(Console.ReadLine());
            //BL.Usuario.DeleteLINQ(idUsuario);
        }
        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el Id del usuario");
            usuario.IdUsuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de usuario");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingresa la contraseña");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento dd/mm/yyyy");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingresa el sexo");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa el estatus");
            usuario.Estatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingresa el CURP");
            usuario.CURP = Console.ReadLine();
            //Console.WriteLine("Ingresa la imagen");
            //usuario.Imagen = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingresa el IdRol");
            //usuario.IdRol = Convert.ToInt32(Console.ReadLine());

            //BL.Usuario.UpdateLINQ(usuario);
        }
        public static void GetAll()
        {
            //ML.Result result = BL.Usuario.GetAllLINQ();

            //if (result.Correct)
            //{
            //    //mostrar los registros
            //    foreach (ML.Usuario usuario in result.Objects)
            //    {
            //        Console.WriteLine("ID: " + usuario.IdUsuario);
            //        Console.WriteLine("User Name: " + usuario.UserName);
            //        Console.WriteLine("Nombre: " + usuario.Nombre);
            //        Console.WriteLine("Apellido paterno: " + usuario.ApellidoPaterno);
            //        Console.WriteLine("Apellido materno: " + usuario.ApellidoMaterno);
            //        Console.WriteLine("Email: " + usuario.Email);
            //        Console.WriteLine("Password: " + usuario.Password);
            //        Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
            //        Console.WriteLine("Sexo: " + usuario.Sexo);
            //        Console.WriteLine("Telefono: " + usuario.Telefono);
            //        Console.WriteLine("Celular: " + usuario.Celular);
            //        Console.WriteLine("Estatus: " + usuario.Estatus);
            //        Console.WriteLine("CURP: " + usuario.CURP);
            //        //Console.WriteLine("Imagen: " + usuario.Imagen);
            //        Console.WriteLine("Id Rol: " + usuario.IdRol);

            //        Console.WriteLine("\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hubo un error " + result.ErrorMessage);
            //}
        }
        //public static void GetById()
        //{
        //    Console.WriteLine("Ingresa el ID del usuario para consultar");
        //    int idUsuario = Convert.ToInt32(Console.ReadLine());
        //    BL.Usuario.GetByIdEF(idUsuario); 

        //    ML.Result result = BL.Usuario.GetByIdLINQ(idUsuario);

        //    if (result.Correct)
        //    {
        //        ML.Usuario usuario = (ML.Usuario)result.Object;
        //        Console.WriteLine("ID: " + usuario.IdUsuario);
        //        Console.WriteLine("User Name: " + usuario.UserName);
        //        Console.WriteLine("Nombre: " + usuario.Nombre);
        //        Console.WriteLine("Apellido paterno: " + usuario.ApellidoPaterno);
        //        Console.WriteLine("Apellido materno: " + usuario.ApellidoMaterno);
        //        Console.WriteLine("Email: " + usuario.Email);
        //        Console.WriteLine("Password: " + usuario.Password);
        //        Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
        //        Console.WriteLine("Sexo: " + usuario.Sexo);
        //        Console.WriteLine("Telefono: " + usuario.Telefono);
        //        Console.WriteLine("Celular: " + usuario.Celular);
        //        Console.WriteLine("Estatus: " + usuario.Estatus);
        //        Console.WriteLine("CURP: " + usuario.CURP);
        //        //Console.WriteLine("Imagen: " + usuario.Imagen);
        //        Console.WriteLine("Id Rol: " + usuario.IdRol);

        //        Console.WriteLine("\n");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Hubo un error " + result.ErrorMessage);
        //    }
        //}
    }
}

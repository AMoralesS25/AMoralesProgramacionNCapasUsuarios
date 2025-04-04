using ML;
using Newtonsoft.Json.Linq;
using PL_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using System.Xml.Linq;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        //CONSUMIR EL SERVICIO DE MANERA FACILL
        // GET: GetAll
        //[HttpGet]
        //public ActionResult GetAll()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    usuario.Rol = new ML.Rol();
        //    usuario.Nombre = "";
        //    usuario.ApellidoPaterno = "";
        //    usuario.ApellidoMaterno = "";
        //    usuario.Rol.IdRol = 0;

        //    //wfc
        //    UsuarioReference.UsuarioClient objeto = new UsuarioReference.UsuarioClient();
        //    var result = objeto.GetAll(usuario);
        //    //    ML.Result result = BL.Usuario.GetAllEF(usuario);


        //    if (result.Correct)
        //    {
        //        usuario.Usuarios = result.Objects.ToList();
        //    }
        //    else
        //    {
        //        usuario.Usuarios = new List<object>();
        //    }
        //    //Llenar el DDL de Roles de busqueda abierta 
        //    ML.Result resultDDLRol = BL.Rol.GetAllLINQ();
        //    usuario.Rol.Roles = resultDDLRol.Objects;
        //    return View(usuario);
        //}

        //[HttpPost]
        //public ActionResult GetAll(ML.Usuario usuario)
        //{

        //    usuario.Nombre = usuario.Nombre == null ? "" : usuario.Nombre;
        //    usuario.ApellidoPaterno = usuario.ApellidoPaterno == null ? "" : usuario.ApellidoPaterno;
        //    usuario.ApellidoMaterno = usuario.ApellidoMaterno == null ? "" : usuario.ApellidoMaterno;
        //    usuario.Rol.IdRol = usuario.Rol.IdRol == 0 ? 0 : usuario.Rol.IdRol;


        //    ML.Result result = BL.Usuario.GetAllEF(usuario);

        //    if (result.Correct)
        //    {
        //        usuario.Usuarios = result.Objects;
        //    }
        //    else
        //    {
        //        usuario.Usuarios = new List<object>();
        //    }
        //    usuario.Rol = new ML.Rol(); //SE ABRIO LA PUERTA

        //    ML.Result resultDDL = BL.Rol.GetAllLINQ(); //todos lo roles 
        //    usuario.Rol.Roles = resultDDL.Objects;
        //    return View(usuario);
        //}

        //[HttpGet]
        //public ActionResult GetAll()
        //{
        //    string action = "http://tempuri.org/IUsuario/GetAll";
        //    string url = "http://localhost:54940/Usuario.svc"; // Cambia a la URL del servicio
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Headers.Add("SOAPAction", action);
        //    request.ContentType = "text/xml;charset=\"utf-8\"";
        //    request.Accept = "text/xml";
        //    request.Method = "POST"; // Cambia a POST ya que estás usando un servicio SOAP

        //    // Crear el sobre SOAP
        //    string soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        //    <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"" xmlns:ml=""http://schemas.datacontract.org/2004/07/ML"" xmlns:arr=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"">
        //    <soapenv:Header/>
        //    <soapenv:Body>
        //          <tem:GetAll>
        //             <!--Optional:-->
        //                <tem:usuario>
        //                <!--Optional:-->
        //                <ml:ApellidoMaterno></ml:ApellidoMaterno>
        //                <!--Optional:-->
        //                <ml:ApellidoPaterno></ml:ApellidoPaterno>
        //                <!--Optional:-->
        //                <ml:Nombre></ml:Nombre>
        //                <!--Optional:-->
        //                <ml:Rol>
        //                   <!--Optional:-->
        //                   <ml:IdRol>0</ml:IdRol>
        //                </ml:Rol>
        //                </tem:usuario>
        //          </tem:GetAll>
        //       </soapenv:Body>
        //    </soapenv:Envelope>";

        //    // Enviar la solicitud
        //    using (Stream stream = request.GetRequestStream())
        //    {
        //        byte[] content = Encoding.UTF8.GetBytes(soapEnvelope);
        //        stream.Write(content, 0, content.Length);
        //    }

        //    // Obtener la respuesta
        //    try
        //    {
        //        using (WebResponse response = request.GetResponse())
        //        {
        //            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        //            {
        //                string result = reader.ReadToEnd();

        //                // Deserializar el XML
        //                var usuarios = GetAllUsuarios(result); // Captura el objeto completo

        //                return View(usuarios); // Asegúrate de que tu vista esté lista para recibir este objeto
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        ViewBag.Error = ex.Message; // Para mostrar en la vista si es necesario
        //    }

        //    return View(); // Devuelve la vista
        //}

        //private ML.Usuario GetAllUsuarios(string xml)
        //{
        //    var usuario1 = new ML.Usuario();
        //    ML.Result result = new ML.Result();
        //    result.Objects = new List<object>();
        //    usuario1.Usuarios = result.Objects;



        //    var xdoc = XDocument.Parse(xml);

        //    // Acceder a GetAllUsuarioResult
        //    var objects = xdoc.Descendants("{http://schemas.microsoft.com/2003/10/Serialization/Arrays}anyType");

        //    foreach (var elem in objects)
        //    {
        //        var usuario = new ML.Usuario();
        //        usuario.Rol = new ML.Rol();
        //        usuario.Direccion = new ML.Direccion();
        //        usuario.Direccion.Colonia = new ML.Colonia();
        //        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
        //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();

        //        // Manejo de IdUsuario null  
        //        //byte[]
        //        int idUsuario;
        //        int.TryParse(elem.Element("{http://schemas.datacontract.org/2004/07/ML}IdUsuario")?.Value, out idUsuario); //0
        //        usuario.IdUsuario = idUsuario;

        //        bool estatus;
        //        bool.TryParse(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Estatus")?.Value, out estatus); //0 o N
        //        usuario.Estatus = estatus;

        //        // Acceso a otros campos
        //        usuario.UserName = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}UserName")?.Value ?? string.Empty);
        //        usuario.Nombre = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);
        //        usuario.ApellidoPaterno = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}ApellidoPaterno")?.Value ?? string.Empty);
        //        usuario.ApellidoMaterno = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}ApellidoPaterno")?.Value ?? string.Empty);
        //        usuario.CURP = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}CURP")?.Value ?? string.Empty);
        //        usuario.Celular = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Celular")?.Value ?? string.Empty);
        //        usuario.Telefono = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Telefono")?.Value ?? string.Empty);
        //        usuario.Email = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Email")?.Value ?? string.Empty);
        //        usuario.FechaNacimiento = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}FechaNacimiento")?.Value ?? string.Empty);
        //        usuario.Password = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Password")?.Value ?? string.Empty);
        //        usuario.Sexo = (string)(elem.Element("{http://schemas.datacontract.org/2004/07/ML}Sexo")?.Value ?? string.Empty);


        //        usuario.Rol.Nombre = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Rol")?.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);
        //        usuario.Direccion.Calle = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Calle")?.Value ?? string.Empty);
        //        usuario.Direccion.NumeroExterior = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}NumeroExterior")?.Value ?? string.Empty);
        //        usuario.Direccion.NumeroInterior = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}NumeroInterior")?.Value ?? string.Empty);
        //        usuario.Direccion.Colonia.CodigoPostal = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}CodigoPostal")?.Value ?? string.Empty);
        //        usuario.Direccion.Colonia.Nombre = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);
        //        usuario.Direccion.Colonia.Municipio.Nombre = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}Municipio")?.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);
        //        usuario.Direccion.Colonia.Municipio.Estado.Nombre = (elem.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}Municipio")?.Element("{http://schemas.datacontract.org/2004/07/ML}Estado")?.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);

        //        result.Objects.Add(usuario);
        //    }

        //    return usuario1; // Devuelve el objeto completo

        //}


        //[HttpGet]
        //public ActionResult Form(int? IdUsuario)
        //{

        //    ML.Usuario usuario = new ML.Usuario(); // ES VACIA
        //    //LA PUERTA CON ROL ESTA CERRRADA 
        //    usuario.Rol = new ML.Rol();


        //    if (IdUsuario == null)
        //    {
        //        //ADD //VACIO
        //        usuario.Rol = new ML.Rol(); //SE ABRIO LA PUERTA
        //        usuario.Direccion = new ML.Direccion(); //SE ABRIO LA PUERTA A DIRECCION
        //        usuario.Direccion.Colonia = new ML.Colonia(); //SE ABRIO LA PUERTA A COLONIA
        //        usuario.Direccion.Colonia.Municipio = new ML.Municipio(); //SE ABRIO LA PUERTA A MUNICIPIO
        //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado(); //SE ABRIO LA PUERTA A ESTADO
        //    }
        //    else
        //    {
        //        //actualizar //lleno //GetById
        //        UsuarioReference.UsuarioClient objeto = new UsuarioReference.UsuarioClient();
        //        var result = objeto.GetById(IdUsuario.Value);

        //        //ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);
        //        ////result.object /unboxing 
        //        usuario = (ML.Usuario)result.Object; //usuario lleno

        //        ML.Result resultDDLMunicipio = BL.Municipio.GetByIdEstadoEF(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
        //        usuario.Direccion.Colonia.Municipio.Municipios = resultDDLMunicipio.Objects;

        //        ML.Result resultDDLColonia = BL.Colonia.GetByIdMunicipioEF(usuario.Direccion.Colonia.Municipio.IdMunicipio);
        //        usuario.Direccion.Colonia.Colonias = resultDDLColonia.Objects;
        //    }

        //    ML.Result resultDDL = BL.Rol.GetAllLINQ(); //todos lo roles 
        //    usuario.Rol.Roles = resultDDL.Objects; //le paso todos los valores a roles para que se pueda ver en el DDL
        //    //usuario.Rol = new ML.Rol(); //SE ABRIO LA PUERTA PERO SI LA VUELVO A ABRIR MIS DATOS SE SOBRESCRIBEN Y TODO SERA NULO

        //    ML.Result estadosDDL = BL.Estado.GetAllEF();//Todos los estados
        //    usuario.Direccion.Colonia.Municipio.Estado.Estados = estadosDDL.Objects;//paso los valores de estado

        //    return View(usuario);
        //}

        //[HttpPost]
        //public ActionResult Form(ML.Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        HttpPostedFileBase file = Request.Files["inptFileImagen"];

        //        if (file != null && file.ContentLength > 0)
        //        {
        //            usuario.Imagen = ConvertirAArrayBytes(file);
        //        }

        //        if (usuario.IdUsuario == 0)
        //        {
        //            UsuarioReference.UsuarioClient objeto = new UsuarioReference.UsuarioClient();
        //            var result = objeto.Add(usuario);

        //            //ML.Result result = BL.Usuario.AddEF(usuario);

        //            if (result.Correct)
        //            {
        //                ViewBag.MensajeVerificado = "Se agrego el usuario de manera correcta";
        //                return PartialView("_NotificacionDeEstado");
        //            }
        //            else
        //            {
        //                ViewBag.MensajeVerificado = "Hubo un error al agregar el usuario";
        //                return PartialView("_NotificacionDeEstado");
        //            }
        //        }
        //        else
        //        {
        //            UsuarioReference.UsuarioClient objeto = new UsuarioReference.UsuarioClient();
        //            var result = objeto.Update(usuario);

        //            //ML.Result result = BL.Usuario.UpdateEF(usuario);
        //            if (result.Correct)
        //            {
        //                ViewBag.MensajeVerificado = "Se actualizo el usuario de manera correcta";
        //                return PartialView("_NotificacionDeEstado");
        //            }
        //            else
        //            {
        //                ViewBag.MensajeVerificado = "Hubo un error al actualizar el usuario";
        //                return PartialView("_NotificacionDeEstado");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ML.Result resultDDLMunicipio = BL.Municipio.GetByIdEstadoEF(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
        //        usuario.Direccion.Colonia.Municipio.Municipios = resultDDLMunicipio.Objects;

        //        ML.Result resultDDLColonia = BL.Colonia.GetByIdMunicipioEF(usuario.Direccion.Colonia.Municipio.IdMunicipio);
        //        usuario.Direccion.Colonia.Colonias = resultDDLColonia.Objects;

        //        ML.Result resultDDL = BL.Rol.GetAllLINQ();
        //        usuario.Rol.Roles = resultDDL.Objects;

        //        ML.Result estadosDDL = BL.Estado.GetAllEF();
        //        usuario.Direccion.Colonia.Municipio.Estado.Estados = estadosDDL.Objects;

        //        return View(usuario);
        //    }

        //}

        //[HttpPost]
        //public ActionResult Form(ML.Usuario nuevoUsuario)
        //{

        //    string url = "http://localhost:54940/Usuario.svc";  // URL del servicio
        //    string soapEnvelope;
        //    string action;
        //    // Cambia a la URL del servicio
        //    // Verificar si IdUsuario es null o 0 (o algún valor que determines como "nuevo")

        //    ML.Usuario usuario = new ML.Usuario();

        //    HttpPostedFileBase file = Request.Files["inptFileImagen"];

        //    if (file != null && file.ContentLength > 0)
        //    {
        //        usuario.Imagen = ConvertirAArrayBytes(file);
        //    }

        //    if (nuevoUsuario.IdUsuario == 0)
        //    {
        //        usuario.Rol = new ML.Rol();
        //        usuario.Direccion = new ML.Direccion();
        //        usuario.Direccion.Colonia = new ML.Colonia();
        //        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
        //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();

        //        //Crear el sobre SOAP para agregar un nuevo usuario
        //        action = "http://tempuri.org/IUsuario/Add";

        //        soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        //        <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"" xmlns:ml=""http://schemas.datacontract.org/2004/07/ML"" xmlns:arr=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"">
        //           <soapenv:Header/>
        //           <soapenv:Body>
        //              <tem:Add>
        //                 <!--Optional:-->
        //                 <tem:usuario>
        //                    <!--Optional:-->
        //                    <ml:ApellidoMaterno>{nuevoUsuario.ApellidoMaterno}</ml:ApellidoMaterno>
        //                    <!--Optional:-->
        //                    <ml:ApellidoPaterno>{nuevoUsuario.ApellidoPaterno}</ml:ApellidoPaterno>
        //                    <!--Optional:-->
        //                    <ml:CURP>{nuevoUsuario.CURP}</ml:CURP>
        //                    <!--Optional:-->
        //                    <ml:Celular>{nuevoUsuario.Celular}</ml:Celular>
        //                    <!--Optional:-->
        //                    <ml:Direccion>
        //                       <!--Optional:-->
        //                       <ml:Calle>{nuevoUsuario.Direccion.Calle}</ml:Calle>
        //                       <!--Optional:-->
        //                       <ml:Colonia>
        //                          <!--Optional:-->
        //                          <ml:IdColonia>{nuevoUsuario.Direccion.Colonia.IdColonia}</ml:IdColonia>
        //                          <!--Optional:-->
        //                          <ml:Municipio>
        //                             <!--Optional:-->
        //                             <ml:Estado>
        //                                <!--Optional:-->
        //                                <ml:IdEstado>{nuevoUsuario.Direccion.Colonia.Municipio.Estado.IdEstado}</ml:IdEstado>
        //                             </ml:Estado>
        //                             <!--Optional:-->
        //                             <ml:IdMunicipio>{nuevoUsuario.Direccion.Colonia.Municipio.IdMunicipio}</ml:IdMunicipio>
        //                          </ml:Municipio>
        //                       </ml:Colonia>
        //                       <!--Optional:-->
        //                       <ml:NumeroExterior>{nuevoUsuario.Direccion.NumeroExterior}</ml:NumeroExterior>
        //                       <!--Optional:-->
        //                       <ml:NumeroInterior>{nuevoUsuario.Direccion.NumeroInterior}</ml:NumeroInterior>
        //                    </ml:Direccion>
        //                    <!--Optional:-->
        //                    <ml:Email>{nuevoUsuario.Email}</ml:Email>
        //                    <!--Optional:-->
        //                    <ml:FechaNacimiento>{nuevoUsuario.FechaNacimiento}</ml:FechaNacimiento>
        //                    <!--Optional:-->
        //                    <ml:Nombre>{nuevoUsuario.Nombre}</ml:Nombre>
        //                    <!--Optional:-->
        //                    <ml:Password>{nuevoUsuario.Password}</ml:Password>
        //                    <!--Optional:-->
        //                    <ml:Rol>
        //                       <!--Optional:-->
        //                       <ml:IdRol>{nuevoUsuario.Rol.IdRol}</ml:IdRol>
        //                    </ml:Rol>
        //                    <!--Optional:-->
        //                    <ml:Sexo>{nuevoUsuario.Sexo}</ml:Sexo>
        //                    <!--Optional:-->
        //                    <ml:Telefono>{nuevoUsuario.Telefono}</ml:Telefono>
        //                    <!--Optional:-->
        //                    <ml:UserName>{nuevoUsuario.UserName}</ml:UserName>
        //                 </tem:usuario>
        //              </tem:Add>
        //           </soapenv:Body>
        //        </soapenv:Envelope>";
        //    }
        //    else
        //    {
        //        // Crear el sobre SOAP para actualizar un usuario existente
        //        action = "http://tempuri.org/IUsuario/Update";
        //        soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        //        <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"" xmlns:ml=""http://schemas.datacontract.org/2004/07/ML"" xmlns:arr=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"">
        //           <soapenv:Header/>
        //           <soapenv:Body>
        //              <tem:Update>
        //                 <!--Optional:-->
        //                 <tem:usuario>
        //                    <!--Optional:-->
        //                    <ml:ApellidoMaterno>{nuevoUsuario.ApellidoMaterno}</ml:ApellidoMaterno>
        //                    <!--Optional:-->
        //                    <ml:ApellidoPaterno>{nuevoUsuario.ApellidoPaterno}</ml:ApellidoPaterno>
        //                    <!--Optional:-->
        //                    <ml:CURP>{nuevoUsuario.CURP}</ml:CURP>
        //                    <!--Optional:-->
        //                    <ml:Celular>{nuevoUsuario.Celular}</ml:Celular>
        //                    <!--Optional:-->
        //                    <ml:Direccion>
        //                       <!--Optional:-->
        //                       <ml:Calle>{nuevoUsuario.Direccion.Calle}</ml:Calle>
        //                       <!--Optional:-->
        //                       <ml:Colonia>
        //                          <!--Optional:-->
        //                          <ml:IdColonia>{nuevoUsuario.Direccion.Colonia.IdColonia}</ml:IdColonia>
        //                          <!--Optional:-->
        //                          <ml:Municipio>
        //                             <!--Optional:-->
        //                             <ml:Estado>
        //                                <!--Optional:-->
        //                                <ml:IdEstado>{nuevoUsuario.Direccion.Colonia.Municipio.Estado.IdEstado}</ml:IdEstado>
        //                             </ml:Estado>
        //                             <!--Optional:-->
        //                             <ml:IdMunicipio>{nuevoUsuario.Direccion.Colonia.Municipio.IdMunicipio}</ml:IdMunicipio>
        //                          </ml:Municipio>
        //                       </ml:Colonia>
        //                       <!--Optional:-->
        //                       <ml:NumeroExterior>{nuevoUsuario.Direccion.NumeroExterior}</ml:NumeroExterior>
        //                       <!--Optional:-->
        //                       <ml:NumeroInterior>{nuevoUsuario.Direccion.NumeroInterior}</ml:NumeroInterior>
        //                    </ml:Direccion>
        //                    <!--Optional:-->
        //                    <ml:Email>{nuevoUsuario.Email}</ml:Email>
        //                    <!--Optional:-->
        //                    <ml:FechaNacimiento>{nuevoUsuario.FechaNacimiento}</ml:FechaNacimiento>
        //                    <!--Optional:-->
        //                    <ml:IdUsuario>{nuevoUsuario.IdUsuario}</ml:IdUsuario>
        //                    <!--Optional:-->
        //                    <ml:Nombre>{nuevoUsuario.Nombre}</ml:Nombre>
        //                    <!--Optional:-->
        //                    <ml:Password>{nuevoUsuario.Password}</ml:Password>
        //                    <!--Optional:-->
        //                    <ml:Rol>
        //                       <!--Optional:-->
        //                       <ml:IdRol>{nuevoUsuario.Rol.IdRol}</ml:IdRol>
        //                    </ml:Rol>
        //                    <!--Optional:-->
        //                    <ml:Sexo>{nuevoUsuario.Sexo}</ml:Sexo>
        //                    <!--Optional:-->
        //                    <ml:Telefono>{nuevoUsuario.Telefono}</ml:Telefono>
        //                    <!--Optional:-->
        //                    <ml:UserName>{nuevoUsuario.UserName}</ml:UserName>
        //                 </tem:usuario>
        //              </tem:Update>
        //           </soapenv:Body>
        //        </soapenv:Envelope>";
        //    }

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Headers.Add("SOAPAction", action); // Aquí ya existe la variable action
        //    request.ContentType = "text/xml;charset=\"utf-8\"";
        //    request.Accept = "text/xml";
        //    request.Method = "POST";

        //    // Enviar la solicitud
        //    using (Stream stream = request.GetRequestStream())
        //    {
        //        byte[] content = Encoding.UTF8.GetBytes(soapEnvelope);
        //        stream.Write(content, 0, content.Length);
        //    }

        //    // Obtener la respuesta
        //    try
        //    {
        //        using (WebResponse response = request.GetResponse())
        //        {
        //            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        //            {
        //                string result = reader.ReadToEnd();
        //                Console.WriteLine("Respuesta SOAP:");
        //                Console.WriteLine(result);
        //                // Aquí puedes manejar la respuesta según sea necesario
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //        ViewBag.Error = ex.Message; // Para mostrar en la vista si es necesario
        //    }

        //    return RedirectToAction("GetAll"); // Redirigir a la lista de usuarios después de agregar o actualizar
        //}


        //[HttpGet]
        //public ActionResult Form(int? IdUsuario)
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    usuario.Rol = new ML.Rol();


        //    if (IdUsuario == null)
        //    {
        //        usuario.Direccion = new ML.Direccion();
        //        usuario.Direccion.Colonia = new ML.Colonia();
        //        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
        //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
        //    }
        //    else
        //    {
        //        // Obtener el usuario por ID
        //        string action = "http://tempuri.org/IUsuario/GetById";
        //        string url = "http://localhost:54940/Usuario.svc";

        //        // Crear el sobre SOAP para obtener un usuario por su ID
        //        string soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        //        <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
        //           <soapenv:Header/>
        //           <soapenv:Body>
        //              <tem:GetById>
        //                 <!--Optional:-->
        //                 <tem:IdUsuario>{IdUsuario}</tem:IdUsuario>
        //              </tem:GetById>
        //           </soapenv:Body>
        //        </soapenv:Envelope>";

        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //        request.Headers.Add("SOAPAction", action);
        //        request.ContentType = "text/xml;charset=\"utf-8\"";
        //        request.Accept = "text/xml";
        //        request.Method = "POST";

        //        // Enviar la solicitud
        //        using (Stream stream = request.GetRequestStream())
        //        {
        //            byte[] content = Encoding.UTF8.GetBytes(soapEnvelope);
        //            stream.Write(content, 0, content.Length);
        //        }

        //        // Obtener la respuesta
        //        try
        //        {
        //            using (WebResponse response = request.GetResponse())
        //            {
        //                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        //                {
        //                    string result = reader.ReadToEnd();
        //                    Console.WriteLine(result);

        //                    // Deserializar el usuario
        //                    usuario = GetUsuarioById(result);

        //                    ML.Result resultDDLMunicipio = BL.Municipio.GetByIdEstadoEF(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
        //                    usuario.Direccion.Colonia.Municipio.Municipios = resultDDLMunicipio.Objects;

        //                    ML.Result resultDDLColonia = BL.Colonia.GetByIdMunicipioEF(usuario.Direccion.Colonia.Municipio.IdMunicipio);
        //                    usuario.Direccion.Colonia.Colonias = resultDDLColonia.Objects;



        //                }
        //            }
        //        }
        //        catch (WebException ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}");
        //            ViewBag.Error = ex.Message; // Para mostrar en la vista si es necesario
        //        }
        //    }

        //    ML.Result resultDDL = BL.Rol.GetAllLINQ();
        //    usuario.Rol.Roles = resultDDL.Objects; 


        //    ML.Result estadosDDL = BL.Estado.GetAllEF();//Todos los estados
        //    usuario.Direccion.Colonia.Municipio.Estado.Estados = estadosDDL.Objects;


        //    return View(usuario); // Devuelve la vista con el usuario si existe
        //}

        //private ML.Usuario GetUsuarioById(string xml)
        //{
        //    var xdoc = XDocument.Parse(xml);
        //    // Acceder a GetUsuarioByIdResult usando el namespace correcto
        //    var usuarioElement = xdoc.Descendants().FirstOrDefault(e =>
        //        e.Name.LocalName == "Object" &&
        //        e.GetDefaultNamespace().NamespaceName == "http://tempuri.org/");

        //    if (usuarioElement != null)
        //    {
        //        ML.Usuario usuario = new ML.Usuario();
        //        usuario.Rol = new ML.Rol();
        //        usuario.Direccion = new ML.Direccion();
        //        usuario.Direccion.Colonia = new ML.Colonia();
        //        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
        //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();

        //        int idUsuario;
        //        int.TryParse(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}IdUsuario")?.Value, out idUsuario); //0
        //        usuario.IdUsuario = idUsuario;

        //        // Acceso a otros campos
        //        usuario.UserName = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}UserName")?.Value ?? string.Empty);
        //        usuario.Nombre = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Nombre")?.Value ?? string.Empty);
        //        usuario.ApellidoPaterno = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}ApellidoPaterno")?.Value ?? string.Empty);
        //        usuario.ApellidoMaterno = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}ApellidoPaterno")?.Value ?? string.Empty);
        //        usuario.CURP = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}CURP")?.Value ?? string.Empty);
        //        usuario.Celular = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Celular")?.Value ?? string.Empty);
        //        usuario.Telefono = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Telefono")?.Value ?? string.Empty);
        //        usuario.Email = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Email")?.Value ?? string.Empty);
        //        usuario.FechaNacimiento = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}FechaNacimiento")?.Value ?? string.Empty);
        //        usuario.Password = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Password")?.Value ?? string.Empty);
        //        usuario.Sexo = (string)(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Sexo")?.Value ?? string.Empty);

        //        int idRol;
        //        int.TryParse(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Rol")?.Element("{http://schemas.datacontract.org/2004/07/ML}IdRol")?.Value, out idRol); //0
        //        usuario.Rol.IdRol = idRol;

        //        usuario.Direccion.Calle = (usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Calle")?.Value ?? string.Empty);
        //        usuario.Direccion.NumeroExterior = (usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}NumeroExterior")?.Value ?? string.Empty);
        //        usuario.Direccion.NumeroInterior = (usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}NumeroInterior")?.Value ?? string.Empty);
        //        usuario.Direccion.Colonia.CodigoPostal = (usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}CodigoPostal")?.Value ?? string.Empty);

        //        int idColonia;
        //        int.TryParse(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}IdColonia")?.Value, out idColonia);
        //        usuario.Direccion.Colonia.IdColonia = idColonia;

        //        int idMunicipio;
        //        int.TryParse(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}Municipio")?.Element("{http://schemas.datacontract.org/2004/07/ML}IdMunicipio")?.Value, out idMunicipio);
        //        usuario.Direccion.Colonia.Municipio.IdMunicipio = idMunicipio;

        //        int idEstado;
        //        int.TryParse(usuarioElement.Element("{http://schemas.datacontract.org/2004/07/ML}Direccion")?.Element("{http://schemas.datacontract.org/2004/07/ML}Colonia")?.Element("{http://schemas.datacontract.org/2004/07/ML}Municipio")?.Element("{http://schemas.datacontract.org/2004/07/ML}Estado")?.Element("{http://schemas.datacontract.org/2004/07/ML}IdEstado")?.Value, out idEstado);
        //        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = idEstado;


        //        return usuario;

        //    }
        //    return null; // O lanzar una excepción si no se encontró el usuario
        //}



        public byte[] ConvertirAArrayBytes(HttpPostedFileBase Foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            byte[] data = reader.ReadBytes((int)Foto.ContentLength);
            return data;
        }

        //[HttpGet]
        //public ActionResult Delete(int IdUsuario)
        //{

        //    //ML.Result result = BL.Usuario.DeleteEF(IdUsuario);
        //    UsuarioReference.UsuarioClient objeto = new UsuarioReference.UsuarioClient();
        //    var result = objeto.Delete(IdUsuario);

        //    if (result.Correct)
        //    {
        //        ViewBag.MensajeVerificado = "Se elimino el usuario de manera correcta";
        //        return PartialView("_NotificacionDeEstado");
        //    }
        //    else
        //    {
        //        ViewBag.MensajeVerificado = "Hubo un error al eliminar el usuario";
        //        return PartialView("_NotificacionDeEstado");
        //    }
        //}

        [HttpPost]
        public JsonResult CambioEstatus(int IdUsuario, bool Estatus)
        {
            ML.Result JsonResult = BL.Usuario.CambiarEstatus(IdUsuario, Estatus);
            return Json(JsonResult, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetByIdEstado(int idEstado)
        {
            ML.Result JsonResult = BL.Municipio.GetByIdEstadoEF(idEstado);
            return Json(JsonResult, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetByIdMunicipio(int idMunicipio)
        {
            ML.Result JsonResult = BL.Colonia.GetByIdMunicipioEF(idMunicipio);
            return Json(JsonResult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CargaMasiva()
        {
            if (Session["RutaExcel"] == null)
            {
                HttpPostedFileBase excelUsuario = Request.Files["inptFileExcel"];
                string extensionPermitida = ".xlsx";

                if (excelUsuario.ContentLength > 0)
                {
                    string extensionObtenida = Path.GetExtension(excelUsuario.FileName);

                    if (extensionObtenida == extensionPermitida)
                    {
                        string ruta = Server.MapPath("~/CargaMasiva/") + Path.GetFileNameWithoutExtension(excelUsuario.FileName) + "-" +
                            DateTime.Now.ToString("ddMMyyyyHmmssff") + ".xlsx";
                        if (!System.IO.File.Exists(ruta))
                        {
                            excelUsuario.SaveAs(ruta);
                            string cadenaConexion = ConfigurationManager.ConnectionStrings["OleDbConnection"] + ruta;
                            ML.Result resultExcel = BL.Usuario.LeerExcel(cadenaConexion);

                            if (resultExcel.Correct)
                            {
                                ML.ResultExcel resultValidacion = BL.Usuario.ValidarExcel(resultExcel.Objects);

                                if (resultValidacion.Errores.Count > 0)
                                {
                                    //hubo errores en el excel mostrar tabla 
                                    ViewBag.ErroresExcel = resultValidacion.Errores;
                                    return PartialView("_ErroresExcel");
                                }
                                else
                                {
                                    //ya lei y valide el excel
                                    Session["RutaExcel"] = ruta;
                                    ViewBag.MensajeVerificado = "No tienes errores en tu excel, oprime el boton insertar";
                                    return PartialView("_ErroresExcel");

                                }
                            }
                            else
                            {
                                ViewBag.Errores = "¡El archivo Excel que ingresaste esta vacío!";
                                return PartialView("_ErroresExcel");

                            }
                        }
                        else
                        {
                            //vista parcial, vuleve a cargar el archivo porque ya existe 
                            ViewBag.Errores = "¡El archivo Excel que ingresaste ya existe!";
                            return PartialView("_ErroresExcel");
                        }
                    }
                    else
                    {
                        //vista parcial no es excel el archivo
                        ViewBag.Errores = "¡El archivo que ingresaste no es un Excel!";
                        return PartialView("_ErroresExcel");
                    }
                }
                else
                {
                    //vista parcial no me diste archivok
                    ViewBag.Errores = "¡No ingresaste ningun archivo!";
                    return PartialView("_ErroresExcel");
                }
            }
            else
            {
                //insertar
                string cadenaConexionRuta = ConfigurationManager.ConnectionStrings["OleDbConnection"] + Session["RutaExcel"].ToString();
                ML.Result resultLeerExcel = BL.Usuario.LeerExcel(cadenaConexionRuta);

                if (resultLeerExcel.Objects.Count > 0)
                {
                    ML.ResultExcel resultInsertExcel = new ML.ResultExcel();
                    resultInsertExcel.Errores = new List<object>();

                    int contadorInsert = 1;
                    bool existErrores = false;

                    //leyo bien 
                    foreach (ML.Usuario usuario in resultLeerExcel.Objects)
                    {
                        ML.ResultExcel resultInsert = new ML.ResultExcel();

                        resultInsert.NumeroRegistro = contadorInsert;

                        ML.Result resultInsertar = BL.Usuario.AddEF(usuario);
                        if (!resultInsertar.Correct)
                        {
                            //mostrar error message 
                            resultInsert.ErrorMessage += "Hubo un error al insertar";
                            existErrores = true;
                        }
                        else
                        {
                            resultInsert.ErrorMessage += "Se inserto de manera correcta";
                        }
                        if (resultInsert.ErrorMessage != null)
                        {
                            resultInsertExcel.Errores.Add(resultInsert);
                        }
                        contadorInsert++;
                    }

                    if (existErrores)
                    {
                        //hubo errores al insertar mostrar tabla 
                        ViewBag.ErroresExcel = resultInsertExcel.Errores;
                        Session["RutaExcel"] = null;
                        return PartialView("_ErroresExcel");
                    }
                    else
                    {
                        ViewBag.MensajeVerificado = "Todos los inserts fueron realizados con exito";
                        Session["RutaExcel"] = null;
                        return PartialView("_NotificacionDeEstado");
                    }


                }

            }//archivo

            Session["RutaExcel"] = null;
            return RedirectToAction("GetAll", "Usuario");

        }

        [NonAction]
        public ML.Result GetAllRest()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (var cliente = new HttpClient())
                {
                    string endPoint = ConfigurationManager.AppSettings["UsuarioEndPoint"].ToString();

                    cliente.BaseAddress = new Uri(endPoint);

                    var respuesta = cliente.GetAsync("GetAll");
                    respuesta.Wait();

                    var resultServicio = respuesta.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        result.Objects = new List<object>();
                        foreach (var item in readTask.Result.Objects)
                        {
                            ML.Usuario usuario = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Usuario>(item.ToString());

                            result.Objects.Add(usuario);
                        }
                    }
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

        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = GetAllRest();

            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                usuario.Usuarios = new List<object>();
            }
            usuario.Rol = new ML.Rol();

            ML.Result resultDDL = BL.Rol.GetAllLINQ();
            usuario.Rol.Roles = resultDDL.Objects;

            return View(usuario);
        }


        [NonAction]
        public ML.Result AddRest(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (var cliente = new HttpClient())
                {
                    string endPoint = ConfigurationManager.AppSettings["UsuarioEndPoint"].ToString();

                    cliente.BaseAddress = new Uri(endPoint);

                    var postTask = cliente.PostAsJsonAsync<ML.Usuario>("Add", usuario);

                    postTask.Wait();

                    var resultServicio = postTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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

        [NonAction]
        public ML.Result UpdateRest(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            int idUsuario = usuario.IdUsuario;
            try
            {
                using (var cliente = new HttpClient())
                {
                    string endPoint = ConfigurationManager.AppSettings["UsuarioEndPoint"].ToString();

                    cliente.BaseAddress = new Uri(endPoint);

                    var putTask = cliente.PutAsJsonAsync<ML.Usuario>("Update/"+idUsuario, usuario);

                    putTask.Wait();

                    var resultServicio = putTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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



        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();

            if (IdUsuario == null)
            {
                usuario.Rol = new ML.Rol();
                usuario.Direccion = new ML.Direccion();
                usuario.Direccion.Colonia = new ML.Colonia();
                usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            }
            else
            {
                var result = GetById(IdUsuario.Value);

                usuario = (ML.Usuario)result.Object;

                ML.Result resultDDLMunicipio = BL.Municipio.GetByIdEstadoEF(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                usuario.Direccion.Colonia.Municipio.Municipios = resultDDLMunicipio.Objects;

                ML.Result resultDDLColonia = BL.Colonia.GetByIdMunicipioEF(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                usuario.Direccion.Colonia.Colonias = resultDDLColonia.Objects;
            }

            ML.Result resultDDL = BL.Rol.GetAllLINQ();
            usuario.Rol.Roles = resultDDL.Objects;

            ML.Result estadosDDL = BL.Estado.GetAllEF();
            usuario.Direccion.Colonia.Municipio.Estado.Estados = estadosDDL.Objects;

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                HttpPostedFileBase file = Request.Files["inptFileImagen"];

                if (file != null && file.ContentLength > 0)
                {
                    usuario.Imagen = ConvertirAArrayBytes(file);
                }

                if (usuario.IdUsuario == 0)
                {

                    ML.Result result = AddRest(usuario);

                    if (result.Correct)
                    {
                        ViewBag.MensajeVerificado = "Se agrego el usuario de manera correcta";
                        return PartialView("_NotificacionDeEstado");
                    }
                    else
                    {
                        ViewBag.Errores = "Hubo un error al agregar";
                        return PartialView("_NotificacionDeEstado");
                    }
                }
                else
                {

                    ML.Result result = UpdateRest(usuario);
                    if (result.Correct)
                    {
                        ViewBag.MensajeVerificado = "Se actualizo el usuario de manera correcta";
                        return PartialView("_NotificacionDeEstado");
                    }
                    else
                    {
                        ViewBag.Errores = "Hubo un error al actualizar";
                        return PartialView("_NotificacionDeEstado");
                    }
                }
            }
            else
            {
                ML.Result resultDDLMunicipio = BL.Municipio.GetByIdEstadoEF(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                usuario.Direccion.Colonia.Municipio.Municipios = resultDDLMunicipio.Objects;

                ML.Result resultDDLColonia = BL.Colonia.GetByIdMunicipioEF(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                usuario.Direccion.Colonia.Colonias = resultDDLColonia.Objects;

                ML.Result resultDDL = BL.Rol.GetAllLINQ();
                usuario.Rol.Roles = resultDDL.Objects;

                ML.Result estadosDDL = BL.Estado.GetAllEF();
                usuario.Direccion.Colonia.Municipio.Estado.Estados = estadosDDL.Objects;

                return View(usuario);
            }

        }

        [NonAction]
        public ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (var cliente = new HttpClient())
                {
                    string endPoint = ConfigurationManager.AppSettings["UsuarioEndPoint"].ToString();

                    cliente.BaseAddress = new Uri(endPoint);

                    var respuesta = cliente.GetAsync("GetById/" + IdUsuario);
                    respuesta.Wait();

                    var resultServicio = respuesta.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Usuario resultUsuario = new ML.Usuario();

                        resultUsuario = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Usuario>(readTask.Result.Object.ToString());
                        result.Object = resultUsuario;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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

        [NonAction]
        public ML.Result DeleteRest(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (var cliente = new HttpClient())
                {
                    string endPoint = ConfigurationManager.AppSettings["UsuarioEndPoint"].ToString();

                    cliente.BaseAddress = new Uri(endPoint);

                    var deleteTask = cliente.DeleteAsync("Delete/" + idUsuario);

                    deleteTask.Wait();

                    var resultServicio = deleteTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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

        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {

            ML.Result result = DeleteRest(IdUsuario);

            if (result.Correct)
            {
                ViewBag.MensajeVerificado = "Se elimino el usuario de manera correcta";
                return PartialView("_NotificacionDeEstado");
            }
            else
            {
                ViewBag.Errores = "Hubo un error al eliminar el usuario";
                return PartialView("_NotificacionDeEstado");
            }
        }
    }
}
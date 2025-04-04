using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL_WebApi.Controllers
{
    [RoutePrefix("api")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("Usuario/GetAll")]
        public IHttpActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            usuario.ApellidoMaterno = "";
            usuario.Rol.IdRol = 0;

            ML.Result result = BL.Usuario.GetAllEF(usuario);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result.ErrorMessage);
            }
        }

        [HttpGet]
        [Route("Usuario/GetById/{idUsuario}")]
        public IHttpActionResult GetById(int idUsuario)
        {

            ML.Result result = BL.Usuario.GetByIdEF(idUsuario);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result.ErrorMessage);
            }
        }

        [HttpPost]
        [Route("Usuario/Add")]
        public IHttpActionResult Add([FromBody] ML.Usuario usuario)
        {

            ML.Result result = BL.Usuario.AddEF(usuario);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result.ErrorMessage);
            }
        }

        [HttpPut]
        [Route("Usuario/Update/{idUsuario}")]
        public IHttpActionResult Update(int idUsuario, [FromBody] ML.Usuario usuario)
        {

            ML.Result result = BL.Usuario.UpdateEF(usuario);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result.ErrorMessage);
            }
        }

        [HttpDelete]
        [Route("Usuario/Delete/{idUsuario}")]
        public IHttpActionResult Update(int idUsuario)
        {

            ML.Result result = BL.Usuario.DeleteEF(idUsuario);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result.ErrorMessage);
            }
        }
    }
}

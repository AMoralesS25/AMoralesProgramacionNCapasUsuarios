using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CandidatoController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Candidato candidato = new ML.Candidato();
            candidato.Vacante = new ML.Vacante();

            ML.Result resultDDLVacante = BL.Vacante.GetAll();
            candidato.Vacante.Vacantes = resultDDLVacante.Objects;

            candidato.Candidatos = new List<object>();

            return View(candidato);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Candidato candidato)
        {
            int idVacante = candidato.Vacante.IdVacante;

            idVacante = idVacante == 0 ? 0 : idVacante;

            ML.Result result = BL.Candidato.GetAll(idVacante);

            if (result.Correct)
            {
                candidato.Candidatos = result.Objects;
            }
            else
            {
                candidato.Candidatos = new List<object>();
            }

            candidato.Vacante = new ML.Vacante();

            ML.Result resultDDLVacante = BL.Vacante.GetAll();
            candidato.Vacante.Vacantes = resultDDLVacante.Objects;
            candidato.Vacante.IdVacante = idVacante;

            return View(candidato);
        }


        [HttpGet]
        public ActionResult Form(int? IdCandidato)
        {
            ML.Candidato candidato = new ML.Candidato();

            if (IdCandidato == null)
            {
                candidato.Universidad = new ML.Universidad();
                candidato.Carrera = new ML.Carrera();
                candidato.BolsaTrabajo = new ML.BolsaTrabajo();
                candidato.Vacante = new ML.Vacante();
            }
            else
            {
                ML.Result result = BL.Candidato.GetById(IdCandidato.Value);
                candidato = (ML.Candidato)result.Object;
            }

            ML.Result resultDDLUniversidad = BL.Universidad.GetAll();
            candidato.Universidad.Universidades = resultDDLUniversidad.Objects;

            ML.Result resultDDLCarrera = BL.Carrera.GetAll();
            candidato.Carrera.Carreras = resultDDLCarrera.Objects;

            ML.Result resultDDLBolsaTrabajo = BL.BolsaTrabajo.GetAll();
            candidato.BolsaTrabajo.BolsasTrabajos = resultDDLBolsaTrabajo.Objects;

            ML.Result resultDDLVacante = BL.Vacante.GetAll();
            candidato.Vacante.Vacantes = resultDDLVacante.Objects;

            return View(candidato);
        }

        [HttpPost]
        public ActionResult Form(ML.Candidato candidato)
        {
            HttpPostedFileBase fileFoto = Request.Files["inptFileFoto"];

            if (fileFoto != null && fileFoto.ContentLength > 0)
            {
                candidato.Foto = ConvertirAArrayBytes(fileFoto);
            }

            HttpPostedFileBase fileCurriculum = Request.Files["inptFileCurriculum"];

            if (fileCurriculum != null && fileCurriculum.ContentLength > 0)
            {
                candidato.Curriculum = ConvertirAArrayBytes(fileCurriculum);
            }

            if (candidato.IdCandidato == 0)
            {
                ML.Result result = BL.Candidato.Add(candidato);

            }
            else
            {
                ML.Result result = BL.Candidato.Update(candidato);
            }

            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult Delete(int IdCandidato)
        {

            ML.Result result = BL.Usuario.DeleteEF(IdCandidato);

            return RedirectToAction("GetAll");
        }

        [NonAction]
        public byte[] ConvertirAArrayBytes(HttpPostedFileBase Archivo)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Archivo.InputStream);
            byte[] data = reader.ReadBytes((int)Archivo.ContentLength);
            return data;
        }

        [HttpGet]
        public FileResult DescargarCurriculum(int? IdCandidato)
        {
            ML.Result result = BL.Candidato.GetById(IdCandidato.Value);
            ML.Candidato candidato = (ML.Candidato)result.Object;

            byte[] archivoCurriculum = candidato.Curriculum;

            string nombreArchivo = "Curriculum_" + candidato.Nombre + candidato.ApellidoPaterno + candidato.ApellidoMaterno + ".pdf";

            if (archivoCurriculum != null && archivoCurriculum.Length > 0)
            {
                return File(archivoCurriculum, System.Net.Mime.MediaTypeNames.Application.Octet, nombreArchivo);
            }
            else
            {
                return null;
            }

        }

    }
}
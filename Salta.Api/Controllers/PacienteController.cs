using Salta.Api.Controllers.Dto;
using Salta.Data.Core;
using Salta.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Salta.Api.Controllers
{

    public class PacienteController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Listado()
        {
            ServicePersona s = new ServicePersona();
            return Ok(s.GetAll());
        }

        [HttpPost]
        public IHttpActionResult Alta(PacienteDto paciente)
        {
            Persona p = PacienteDto.GetModelPersona(paciente);

            ServicePersona s = new ServicePersona();

            s.AltaPersona(p, paciente.Genero,Convert.ToInt32(paciente.ObraSocial),
                Convert.ToInt32(paciente.FactorSanguineo),Convert.ToInt32 (paciente.GrupoSanguineo));

            return Ok();
        }

        //[HttpPut]
        //public IHttpActionResult Put(PacienteDto paciente)
        //{
        //    Persona p = PacienteDto.GetModelPersona(paciente);

        //    ServicePersona s = new ServicePersona();

        //    s.ModificarPersona(paciente.Id, p, paciente.Genero, paciente.ObraSocial, paciente.FactorSanguineo, paciente.GrupoSanguineo);

        //    return Ok();
        //}

    }
}

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
            try
            {
                ServicePersona s = new ServicePersona();
                return Ok(s.GetAll());
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                });
            }

        }

        [HttpPost]
        public IHttpActionResult Post(PacienteDto paciente)
        {
            try
            {
                Persona p = PacienteDto.GetModelPersona(paciente);

                ServicePersona s = new ServicePersona();

                s.AltaPersona(p, paciente.Sexo, paciente.ObraSocial, paciente.FactorSanguineo);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) {
                    Content = new StringContent(ex.Message)
                });
            }
        }

        [HttpPut]
        public IHttpActionResult Put(PacienteDto paciente)
        {
            Persona p = PacienteDto.GetModelPersona(paciente);

            ServicePersona s = new ServicePersona();

            s.ModificarPersona(paciente.Id, p, paciente.Sexo, paciente.ObraSocial, paciente.FactorSanguineo);

            return Ok();
        }

    }
}

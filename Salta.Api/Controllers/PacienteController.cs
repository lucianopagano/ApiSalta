﻿using Salta.Api.Controllers.Dto;
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
        public IHttpActionResult Ping(PacienteDto paciente)
        {
            return Ok<int>(1);
        }

        [HttpPost]
        public IHttpActionResult Alta(PacienteDto paciente)
        {
            Persona p = PacienteDto.GetModelPersona(paciente);

            ServicePersona s = new ServicePersona();

            s.AltaPersona(p);

            return Ok();
        }

    }
}

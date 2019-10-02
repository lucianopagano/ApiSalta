using Newtonsoft.Json;
using Salta.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salta.Api.Controllers.Dto
{
    [JsonObject]
    public class PacienteDto
    {
        
        public string NumeroHistClincia { get; set; }

        public int Edad { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public static Persona GetModelPersona(PacienteDto pDto)
        {
            Persona p = new Persona();

            p.Nombre = pDto.Nombre;
            p.Apellido = pDto.Apellido;
            p.Dni = pDto.Dni;
            p.NumeroHistClincia = pDto.NumeroHistClincia;
            p.Edad = pDto.Edad;

            return p;
        } 
    }
}
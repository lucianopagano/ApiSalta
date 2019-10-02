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

        //1 Masc
        //2 Fem
        public int Sexo { get; set; }

        //Swiss Medical 0
        //Pami 1
        //IOMA 2 
        public int ObraSocial { get; set; }

        //1 a+
        //2 0+
        //3 a-
        public int FactorSanguineo { get; set; }

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
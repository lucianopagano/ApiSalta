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
        public string Id { get; set; }

        public string NumeroOrden { get; set; }

        public int Edad { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DocumentoDeIdentidad { get; set; }

        //1 Masc
        //2 Fem
        public int Genero { get; set; }

        //Swiss Medical 0
        //Pami 1
        //IOMA 2 
        public string ObraSocial { get; set; }

        public string FactorSanguineo { get; set; }

        public string GrupoSanguineo { get; set; }

        public static Persona GetModelPersona(PacienteDto pDto)
        {
            Persona p = new Persona();

            p.Nombre = pDto.Nombre;
            p.Apellido = pDto.Apellido;
            p.Dni = pDto.DocumentoDeIdentidad;
            p.NumeroHistClincia = pDto.NumeroOrden;
            p.Edad = pDto.Edad;

            return p;
        } 
    }
}
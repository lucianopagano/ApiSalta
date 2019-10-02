using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salta.Data.Core
{
    public class Persona
    {
        public ObjectId Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string NumeroHistClincia { get; set; }
        public int Edad { get; set; }

        public Sexo Sexo { get; set; }

        public ObraSocial Obra { get; set; }

        public FactorSanguineo Factor { get; set; }
    }


}


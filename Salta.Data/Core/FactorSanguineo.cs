using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salta.Data.Core
{
    public class FactorSanguineo
    {
        public ObjectId Id { get; set; }
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
    }
}

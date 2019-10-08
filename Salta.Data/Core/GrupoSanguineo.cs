using MongoDB.Bson;
using System;

namespace Salta.Data.Core
{
    public class GrupoSanguineo
    {
        public ObjectId Id { get; set; }
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
    }
}

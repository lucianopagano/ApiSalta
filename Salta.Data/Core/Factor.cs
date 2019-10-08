using MongoDB.Bson;
using System;

namespace Salta.Data.Core
{
    public class Factor
    {
        public ObjectId Id { get; set; }
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
    }
}

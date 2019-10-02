using System.Linq;
using MongoDB.Driver;
using Salta.Data.Core;
using MongoDB.Bson;

namespace Salta.Data.Services
{
    public class ServicePersona
    {
        const string connectionString = "mongodb://localhost:27017";
        public void AltaPersona(Persona persona, int sexo, int obrasocial, int factorSanguineo)
        {
            
            // Create a MongoClient object by using the connection string
            var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");


            var filter = new BsonDocument("Codigo",sexo);
            Sexo s = database.GetCollection<Sexo>("Sexo").Find<Sexo>(filter).FirstOrDefault();

            filter = new BsonDocument("Codigo", obrasocial);
            ObraSocial obra = database.GetCollection<ObraSocial>("ObraSocial").Find<ObraSocial>(filter).FirstOrDefault();

            filter = new BsonDocument("Codigo", factorSanguineo);
            FactorSanguineo factor = database.GetCollection<FactorSanguineo>("FactorSanguineo").Find<FactorSanguineo>(filter).FirstOrDefault();

            persona.Sexo = s;
            persona.Obra = obra;
            persona.Factor = factor;

            collection.InsertOne(persona);
        }

        public Persona GetPersonaById(string id)
        {
            // Create a MongoClient object by using the connection string
            var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            var filter = new BsonDocument("_id", new ObjectId(id));

            Persona p = collection.Find<Persona>(filter).FirstOrDefault();

            return p;
        }

    }
}

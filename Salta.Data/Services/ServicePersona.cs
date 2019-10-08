using System.Linq;
using MongoDB.Driver;
using Salta.Data.Core;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Configuration;

namespace Salta.Data.Services
{
    public class ServicePersona
    {
        

        const string connectionString = "mongodb+srv://lucianopagano:lucho123@cluster0-adezy.azure.mongodb.net/Salta?retryWrites=true&w=majority";
            
        MongoClient client;

        public ServicePersona()
        {
            //ConfigurationManager.ConnectionStrings["MongoDB"].ToString();

            this.client = new MongoClient("mongodb+srv://lucianopagano:lucho123@cluster0-adezy.azure.mongodb.net/test?retryWrites=true&w=majority");
            //var database = client.GetDatabase("test");

            //this.client= new MongoClient(connectionString);
        }

        public void AltaPersona(Persona persona, int sexo, int obrasocial, int factorSanguineo)
        {
            
            // Create a MongoClient object by using the connection string
            //MongoClient client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            persona.Sexo = this.GetSexo(sexo);
            persona.Obra = this.GetObraSocial(obrasocial);
            persona.Factor = this.GetFactorSanguineo(factorSanguineo);

            collection.InsertOne(persona);
        }

        public void ModificarPersona(string id, Persona personaAModificar, int sexo, int obrasocial, int factorSanguineo)
        {
            Persona per = GetPersonaById(id);

            per.Nombre = personaAModificar.Nombre;
            per.Apellido = personaAModificar.Apellido;
            per.Dni = personaAModificar.Dni;
            per.NumeroHistClincia = personaAModificar.NumeroHistClincia;
            per.Edad = personaAModificar.Edad;

            per.Sexo = this.GetSexo(sexo);
            per.Obra = this.GetObraSocial(obrasocial);
            per.Factor = this.GetFactorSanguineo(factorSanguineo);

            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");


            var collection = database.GetCollection<Persona>("Persona");

            var filter = Builders<Persona>.Filter.Eq(s => s.Id, new ObjectId(id));
            var result = collection.ReplaceOne(filter, per);

        }

        public Persona GetPersonaById(string id)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            var filter = new BsonDocument("_id", new ObjectId(id));

            Persona p = collection.Find<Persona>(filter).FirstOrDefault();

            return p;
        }

        public List<Persona> GetAll()
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            return collection.AsQueryable<Persona>().ToList();
            
        }

        public Sexo GetSexo(int codigo)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            var filter = new BsonDocument("Codigo", codigo);
            Sexo s = database.GetCollection<Sexo>("Sexo").Find<Sexo>(filter).FirstOrDefault();
            return s;
        }

        public ObraSocial GetObraSocial(int codigo)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            var filter = new BsonDocument("Codigo", codigo);

            ObraSocial obra = database.GetCollection<ObraSocial>("ObraSocial").Find<ObraSocial>(filter).FirstOrDefault();

            return obra; 
        }

        public FactorSanguineo GetFactorSanguineo(int codigo)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            var filter = new BsonDocument("Codigo", codigo);

            filter = new BsonDocument("Codigo", codigo);
            FactorSanguineo factor = database.GetCollection<FactorSanguineo>("FactorSanguineo").Find<FactorSanguineo>(filter).FirstOrDefault();
            return factor;
        }

    }
}

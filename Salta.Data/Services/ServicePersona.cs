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
        
        //const string connectionString = "mongodb+srv://lucianopagano:lucho123@cluster0-adezy.azure.mongodb.net/Salta?retryWrites=true&w=majority";
            
        MongoClient client;
        IMongoDatabase database;

        public ServicePersona()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();

            this.client = new MongoClient(connectionString);
            
            this.database = client.GetDatabase("Salta");
        }

        public void AltaPersona(Persona persona, int sexo, int obrasocial, int factorSanguineo, int grupo)
        {
                        

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            persona.Sexo = this.GetSexo(sexo);
            persona.Obra = this.GetObraSocial(obrasocial);
            persona.Factor = this.GetFactorSanguineo(factorSanguineo);
            persona.Grupo = this.GetGrupoSanguineo(grupo);

            collection.InsertOne(persona);
        }

        public void ModificarPersona(string id, Persona personaAModificar, int sexo, int obrasocial, int factorSanguineo, int grupo)
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


            var collection = database.GetCollection<Persona>("Persona");

            var filter = Builders<Persona>.Filter.Eq(s => s.Id, new ObjectId(id));
            var result = collection.ReplaceOne(filter, per);

        }

        public Persona GetPersonaById(string id)
        {


            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            var filter = new BsonDocument("_id", new ObjectId(id));

            Persona p = collection.Find<Persona>(filter).FirstOrDefault();

            return p;
        }

        public List<object> GetAll()
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);


            //get mongodb collection
            var collection = database.GetCollection<Persona>("Persona");

            List<object> lista = collection.AsQueryable<Persona>().ToList().Select(p =>
            new {
                Id = p.Id.ToString(),
                NumeroOrden = p.NumeroHistClincia,
                Apellido = p.Apellido,
                Nombre= p.Nombre,
                DocumentoDeIdentidad = p.Dni,
                Edad = p.Edad,
                FactorSanguineo = p.Factor.Descripcion,
                GrupoSanguineo = p.Grupo,
                ObraSocial = p.Obra.Descripcion,
                Genero= p.Sexo.Descripcion
            }).ToList<object>();


            return lista;
        }

        public Sexo GetSexo(int codigo)
        {
            var filter = new BsonDocument("Codigo", codigo);
            Sexo s = database.GetCollection<Sexo>("Sexo").Find<Sexo>(filter).FirstOrDefault();
            return s;
        }

        public ObraSocial GetObraSocial(int codigo)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            var filter = new BsonDocument("Codigo", codigo);

            ObraSocial obra = database.GetCollection<ObraSocial>("ObraSocial").Find<ObraSocial>(filter).FirstOrDefault();

            return obra; 
        }

        public Factor GetFactorSanguineo(int codigo)
        {
            // Create a MongoClient object by using the connection string
            //var client = new MongoClient(connectionString);

            var filter = new BsonDocument("Codigo", codigo);

            filter = new BsonDocument("Codigo", codigo);
            Factor factor = database.GetCollection<Factor>("Factor").Find<Factor>(filter).FirstOrDefault();
            return factor;
        }

        public GrupoSanguineo GetGrupoSanguineo(int codigo)
        {
            // Create a MongoClient object by using the connection string

            var filter = new BsonDocument("Codigo", codigo);

            filter = new BsonDocument("Codigo", codigo);
            GrupoSanguineo grupo = database.GetCollection<GrupoSanguineo>("GrupoSanguineo").Find<GrupoSanguineo>(filter).FirstOrDefault();
            return grupo;
        }

    }
}

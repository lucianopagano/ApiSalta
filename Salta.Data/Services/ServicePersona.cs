using MongoDB.Driver;
using Salta.Data.Core;

namespace Salta.Data.Services
{
    public class ServicePersona
    {
        const string connectionString = "mongodb://localhost:27017";
        public void AltaPersona(Persona persona)
        {
            
            // Create a MongoClient object by using the connection string
            var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("Salta");

            //get mongodb collection
            var collection = database.GetCollection<Persona>("Personas");


            collection.InsertOne(persona);
        }

    }
}

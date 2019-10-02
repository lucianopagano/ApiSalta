using System;

using Salta.Data.Services;
using Salta.Data.Core;

namespace Salta
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePersona s = new ServicePersona();

            Persona p = new Persona();

            s.AltaPersona("Luciano","Pagano","34803204");

            Console.ReadKey();

        }
    }
}

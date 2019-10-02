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

            Persona p = s.GetPersonaById("5d94b7953d0c303b88d41a71");

            Console.WriteLine(p.Sexo.Descripcion);
            Console.WriteLine(p.Obra.Descripcion);
            Console.WriteLine(p.Factor.Descripcion);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;

namespace Ejercicio9Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            Cine c = new Cine();
            List<Persona> listP = new List<Persona>();
            for (int i = 0; i < 1000; i++)
            {
                Persona p = new Persona(c);
                listP.Add(p);

            }
            c.mostrarSala();
            

            
        }
    }
}

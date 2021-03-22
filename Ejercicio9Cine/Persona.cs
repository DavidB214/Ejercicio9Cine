using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9Cine
{
    class Persona
    {
        static char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
        static int _nombre=0;
        int _edad;
        decimal _dinero;
        int fila;
        int columna;
        String asiento;
        static Random r = new Random();

        public string Asiento { get => asiento; set => asiento = value; }

        public Persona(Cine c)
        {
            _nombre++;
            _edad = r.Next(4, 40);
            _dinero= r.Next(0, 40);
            Sentar(c);
        }
        public override string ToString()
        {
            return _nombre+" "+_edad+" "+_dinero+" "+asiento;
        }
        public void Sentar(Cine c)
        {
            if (c.PrecioEntrada <= _dinero)
            {
                if (!c.lleno())
                {
                    if (_edad >= c.Pelicula.EdadMinima)
                    {//dar asiento random y si esta ocupado buscar uno libre
                        Random r = new Random();
                        fila = r.Next(0, 8);
                        columna = r.Next(0,9);
                        if (c.ocupar(fila, columna))
                        {
                            asiento = (fila + 1) + "" + letras[columna];
                        }
                        else
                        {
                            asiento = c.buscarAsiento();
                        }
                        
                    }
                }
                else Console.WriteLine("SALA LLENA NO SE HA PODIDO AÑADIR A MAS GENTE");
            }
        }
    }
}

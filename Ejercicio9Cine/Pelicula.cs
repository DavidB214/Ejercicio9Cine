using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9Cine
{
    class Pelicula
    {
        String _titulo;
        int _duracion;
        int _edadMinima;
        String _director;

        public Pelicula()
        {
            _titulo = "Titanic";
            _duracion= 3;
            _edadMinima = 16;
            _director = "James Cameron";
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public int Duracion { get => _duracion; set => _duracion = value; }
        public int EdadMinima { get => _edadMinima; set => _edadMinima = value; }
        public string Director { get => _director; set => _director = value; }
    }
}

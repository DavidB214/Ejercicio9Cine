using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9Cine
{
    class Cine
    {
        public static char[] letras = {'A','B','C','D','E','F', 'G', 'H', 'I' };
        static int[,] sala = new int[8, 9];
        Pelicula _pelicula;
        decimal _precioEntrada;
        public Cine()
        {
            _pelicula = new Pelicula();
            _precioEntrada = 10;
        }

        public decimal PrecioEntrada { get => _precioEntrada; set => _precioEntrada = value; }
        internal Pelicula Pelicula { get => _pelicula; set => _pelicula = value; }

        public Boolean lleno()
        {
            for (int i = 0; i < sala.GetLength(0); i++)
            {
                for (int j = 0; j < sala.GetLength(1); j++)
                {
                    if (sala[i, j] != 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public Boolean ocupar(int f,int c)
        {
            if (sala[f, c] != 1)
            {
                sala[f, c] = 1;
                return true;
            }
            return false;
        }
        public String buscarAsiento()
        {
            for (int i = 0; i < sala.GetLength(0); i++)
            {
                for (int j = 0; j < sala.GetLength(1); j++)
                {
                    if (sala[i, j] != 1)
                    {
                        sala[i, j] = 1;
                        return (i + 1) + "" + letras[j];
                    }
                }
            }

            return "lleno";
        }
        public void mostrarSala()
        {
            for (int i = 0; i < sala.GetLength(0); i++)
            {
                for (int j = 0; j < sala.GetLength(1); j++)
                {
                    if (sala[i, j] != 1)
                    {
                        Console.Write("__ ");

                    }else
                    Console.Write((i + 1) + "" +letras[j] + " ");
                }

                Console.WriteLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Win_Bootstrap_Cartas

{
    class Carta
    {
        int raza;
        int numero;
        string[] razas = { "Orcos", "Elfos", "Enanos", "Gnomos" };

        public Carta()
            //CONSTRUCTOR X DEFECTO
        {
            raza = 0;
            numero = 0;
        }

        public Carta(int n, int r)
        {
            numero = n;
            raza = r;
        }

        public string ToString()
        {
            return numero + " de " + razas[raza];
        }
    }
}

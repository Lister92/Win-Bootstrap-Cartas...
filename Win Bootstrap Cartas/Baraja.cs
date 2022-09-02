using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Win_Bootstrap_Cartas

{
    class Baraja
    {
        List<Carta> baraja = new List<Carta>();
        Carta card;
        Random random = new Random();

        internal List<Carta> lbBaraja { get => baraja; set => baraja = value; }

        public Baraja()
        {
            int x, y;
            for (y = 0; y < 4; y++)
            {
                for (x = 0; x < 12; x++)
                {
                    card = new Carta(x + 1, y);
                    baraja.Add(card);
                }
            }
        }

        public int NumeroCartas()
        {
            return baraja.Count;
        }
        public Carta RobarCarta()
        {
            Carta aux = baraja[0];
            baraja.RemoveAt(0);
            NumeroCartas();
            return aux;
        }

        public Carta CogeCarta(int n)
        {
            Carta aux = baraja[n];
            if (n < baraja.Count && n > 0)
            {
                baraja.RemoveAt(n);
                NumeroCartas();                
                return aux;
            }
            else
                return null;
        }
        public Carta CogeCartaAlAzar()
        {
            int rd = random.Next(baraja.Count);
            Carta auxAzar = baraja[rd];          
            return auxAzar;            
        }

        public string ToString()
        {
            string aux = "";
            for (int i = 0; i<baraja.Count; i++)
			{
                aux += baraja[i].ToString() + "\n";
		    }
            return null;
        }
        public void Barajar()
        {
            baraja = baraja.OrderBy(a => random.Next()).ToList();
            ToString();

        }

    }
}


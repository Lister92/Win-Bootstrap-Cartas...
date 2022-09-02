using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Bootstrap_Cartas
{
    
    public partial class Form1 : Form
    {
        Baraja baraja = new Baraja();
        public Form1()
        {
            InitializeComponent();
            updateList();
        }

        private void butCartaR_Click(object sender, EventArgs e)
        {          
            MessageBox.Show(baraja.CogeCartaAlAzar().ToString());
            updateList();
        }

        private void butNumCartas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.NumeroCartas().ToString());
        }

        private void butSacarCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.RobarCarta().ToString());
            updateList();
        }

        private void butListaCartas_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void butBarajar_Click(object sender, EventArgs e)
        {
            baraja.Barajar();
            updateList();
        }
        private void updateList()
        {
            listCartas.Items.Clear();
            for (int i = 0; i < baraja.NumeroCartas(); i++)
            {
                listCartas.Items.Add(baraja.lbBaraja[i].ToString());
            }
        }
    }
}

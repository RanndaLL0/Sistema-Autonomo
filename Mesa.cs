using MagicTrickServer;
using SistemaPI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPI
{
    public partial class panelCarta : Form
    {

        public string[] Cartas { get; set; }
        List<Panel> panels = new List<Panel>();
        public int Id { get; set; }

        public panelCarta(string[] cartas,int id)
        {
            Cartas = cartas;
            Id = id;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void imgCarta(Panel carta,string n)
        {
            switch (n)
            {
                case "C":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\ced40\OneDrive\Documentos\Sistema_Autonomo\Sistema-Autonomo\Resources\Copas1.png");
                    break;
                case "O":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\ced40\OneDrive\Documentos\Sistema_Autonomo\Sistema-Autonomo\Resources\Ouros1.png");
                    break;
                case "E":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\ced40\OneDrive\Documentos\Sistema_Autonomo\Sistema-Autonomo\Resources\Espadas1.png");
                    break;
            }
        }

        public int Njogadores()
        {
            string listaDeJogadores = Jogo.ListarJogadores(Id);

            listaDeJogadores = listaDeJogadores.Replace("\r", "");
            if (listaDeJogadores.Length > 0)
            {
                listaDeJogadores = listaDeJogadores.Substring(0, listaDeJogadores.Length - 1);
            }
            string[] listaJ = listaDeJogadores.Split('\n');
            return listaJ.Length;
        }

        public void ExibirMao()
        {
           
            foreach(Control c in Controls)
            {
                if(c is Panel)
                {
                    Controls.Remove(c);
                    c.Dispose();
                }
            }

            int nJogadores = Njogadores();

            //Posição inicial das cartas
            int x = 200;
            int y = 400;
            int count = 0;
            for(int i = 0; i < Cartas.Length - 1; i++)
            {
                Panel carta = new Panel();
                string[] auxCarta = Cartas[i].ToString().Split(',');
                
                if(nJogadores == 2 && count == 6)
                {
                    x = 200;
                    y = 500;
                }
                else if(nJogadores > 2 && count == 7)
                {
                    //x = 
                    //y = 
                }
                imgCarta(carta, auxCarta[2]);
                carta.Height = 70;
                carta.Width = 61;
                carta.Left = x;
                carta.Top = y;

                count++;
                carta.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(carta);
                x += 69;
            }
        }

    }
}

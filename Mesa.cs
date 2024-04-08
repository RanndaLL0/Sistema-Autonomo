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
        public Point MouseLocation; ////Posição do Mouse
        public string[] Cartas { get; set; } //Cartas da mesa
        public int Id { get; set; } //Id da partida
        public int IdJogador { get; set; }
        public int CartaJogada { get; set; }

        public panelCarta(string[] cartas,int id)
        {
            Cartas = cartas;
            Id = id;
            InitializeComponent();
        }

        //posicao do forms

        private void MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        //Botoes do cabeçalho

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
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\Copas1.png");
                    break;
                case "O":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\Ouros1.png");
                    break;
                case "E":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\Espadas1.png");
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
        public void ExibirJogada()
        {
            string retorno = Jogo.ExibirJogadas(Id);
        }

        public void AtualizarP()
        {
            List<Control> controls = new List<Control>();
            foreach (Control c in Controls) 
            {
                if(c is Panel && c != pnlHeader)
                {
                    controls.Add(c);
                }
            }
            foreach(Control c in controls)
            {
                Controls.Remove(c);
                c.Dispose();
            }
        }

        public void ExibirMao()
        {
            AtualizarP();
            foreach(Control c in Controls)
            {
                if(c is Panel)
                {
                    if(c != pnlHeader)
                    {
                        Controls.Remove(c);
                        c.Dispose();
                    }
                }
            }

            int nJogadores = Njogadores();

            //Posição inicial das cartas
            int x = 250;
            int y = 520;
            int count = 0;
            for(int i = 0; i < Cartas.Length - 1; i++)
            {
                Panel carta = new Panel();
                string[] auxCarta = Cartas[i].ToString().Split(',');
                
                if(nJogadores == 2 && count == 6)
                {
                    x = 250;
                    y = 620;
                }
                else if(nJogadores == 2 && count == 12)
                {
                    x = 250;
                    y = 150;
                }
                else if(nJogadores == 2 && count == 18)
                {
                    x = 250;
                    y = 50;
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
                Refresh();
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

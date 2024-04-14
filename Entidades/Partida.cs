using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;

namespace SistemaPI.Entidades
{
    public class Partida
    {
        public int NJogadores { get; set; }
        public string[] Cartas { get; set; }
        public List<int> IdJogadores { get; set; }

        List<Jogador> Jogadores = new List<Jogador>();

        public Partida(string[] cartas, int qtdJogadores, List<int> idJogadores,Form mesa)
        {
            IdJogadores = idJogadores;
            Cartas = cartas;
            NJogadores = qtdJogadores;
            IniciarJogador();
            AdicionarCartas2();
            ExibirMao(mesa);
        }

        public void IniciarJogador()
        {
            for(int i = 0; i < NJogadores;i++)
            {
                if(i == 0)
                {
                    Jogadores.Add(new Jogador(900, 550, IdJogadores[i]));
                }
                else if(i == 1)
                {
                    Jogadores.Add(new Jogador(900, 380, IdJogadores[i]));
                }
                else if(i == 2)
                {
                    Jogadores.Add(new Jogador(900, 210, IdJogadores[i]));
                }
                else if(i == 3)
                {
                    Jogadores.Add(new Jogador(900, 40, IdJogadores[i]));
                }
            }
        }

        public void AdicionarCartas2()
        {

            if (Jogadores.Count == 2)
            {
                // Primeiro jogador (Jogadores[0])
                int x1 = Jogadores[0].Xinicial;
                int y1 = Jogadores[0].Yinicial;
                for (int i = 0; i < 12; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x1;
                    p.Top = y1;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[0].Cartas.Add(p, i);

                    x1 += 49;
                    if (i == 5)
                    {
                        // Muda para a próxima linha após adicionar as primeiras 6 cartas
                        x1 = Jogadores[0].Xinicial;
                        y1 += 70;
                    }
                }

                int x2 = Jogadores[1].Xinicial;
                int y2 = Jogadores[1].Yinicial;
                for (int i = 12; i < 24; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x2;
                    p.Top = y2;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[1].Cartas.Add(p, i);

                    x2 += 49;
                    if (i == 17)
                    {
                        x2 = Jogadores[1].Xinicial;
                        y2 += 70;
                    }
                }
            }
            else
            {
                AdicionarCartas4();
            }
        }

        public void AdicionarCartas4()
        {

            if (Jogadores.Count == 4)
            {
                // Primeiro jogador (Jogadores[0])
                int x1 = Jogadores[0].Xinicial;
                int y1 = Jogadores[0].Yinicial;
                for (int i = 0; i < 14; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x1;
                    p.Top = y1;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[0].Cartas.Add(p, i);

                    x1 += 49;
                    if (i == 6)
                    {
                        // Muda para a próxima linha após adicionar as primeiras 6 cartas
                        x1 = Jogadores[0].Xinicial;
                        y1 += 70;
                    }
                }

                int x2 = Jogadores[1].Xinicial;
                int y2 = Jogadores[1].Yinicial;
                for (int i = 14; i < 28; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x2;
                    p.Top = y2;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[1].Cartas.Add(p, i);

                    x2 += 49;
                    if (i == 20)
                    {
                        x2 = Jogadores[1].Xinicial;
                        y2 += 70;
                    }
                }

                int x3 = Jogadores[2].Xinicial;
                int y3 = Jogadores[2].Yinicial;
                for (int i = 28; i < 42; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x3;
                    p.Top = y3;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[2].Cartas.Add(p, i);

                    x3 += 49;
                    if (i == 34)
                    {
                        x3 = Jogadores[2].Xinicial;
                        y3 += 70;
                    }
                }

                int x4 = Jogadores[3].Xinicial;
                int y4 = Jogadores[3].Yinicial;
                for (int i = 42; i < 56; i++)
                {
                    string[] auxCarta = Cartas[i].ToString().Split(',');
                    Panel p = new Panel();
                    p.Height = 55;
                    p.Width = 44;
                    p.Left = x4;
                    p.Top = y4;
                    imgCarta(p, auxCarta[2]);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    Jogadores[3].Cartas.Add(p, i);

                    x4 += 49;
                    if (i == 48)
                    {
                        x4 = Jogadores[3].Xinicial;
                        y4 += 70;
                    }
                }
            }
        }

        public void imgCarta(Panel carta, string n)
        {
            switch (n)
            {
                case "C":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\C.png");
                    break;
                case "O":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\O.png");
                    break;
                case "E":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\E.png");
                    break;
                case "S":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\S.png");
                    break;
                case "T":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\T.png");
                    break;
                case "L":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\L.png");
                    break;
                case "P":
                    carta.BackgroundImage = Image.FromFile(@"C:\Users\Star\Projeto\SistemaPI\Resources\P.png");
                    break;
            }
        }

        public void ExibirMao(Form mesa)
        {
            foreach(Jogador j in Jogadores)
            {
                foreach(Panel p in j.Cartas.Keys)
                {
                    mesa.Controls.Add(p);
                }
            }
        }
        
    }
}

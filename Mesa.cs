using MagicTrickServer;
using SistemaPI.Entidades;
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
        public int IdPartida { get; set; } //Id da partida
        public int IdJogador { get; set; }
        public List<int> IdJogadores = new List<int>();
        public int CartaJogada { get; set; }
        ListBox lstCartas { get; set; }
        public Partida Partida { get; set; }

        public panelCarta(string[] cartas, int idPartida, ListBox lstCartas,List<int> ids)
        {
            Cartas = cartas;
            IdPartida = idPartida;
            IdJogadores = ids;
            InitializeComponent();

            int qtdJogadores = QtdJogadores(ids);

            Partida = new Partida(cartas,qtdJogadores,IdPartida,IdJogadores,this);

            CartasLog(lstCartas);
        }

        public void CartasLog(ListBox lstCartas)
        {
            this.lstCartas = lstCartas;
            this.lstCartas.Left = 40;
            this.lstCartas.Top = 100;
            this.lstCartas.Visible = true;
            this.Controls.Add(lstCartas);
        }

        public int QtdJogadores(List<int> jogadores)
        {
            if(jogadores.Count == 2)
            {
                return 2;
            }
            if(jogadores.Count == 4)
            {
                return 4;
            }
            return -1;
        }

        public void ListarMao()
        {
            this.lstCartas.Items.Clear();
            int idPartida = IdPartida;
            string retorno = Jogo.ConsultarMao(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] cartas = retorno.Split('\n');

            for (int i = 0; i < cartas.Length; i++)
            {
                lstCartas.Items.Add(cartas[i]);
            }
            Cartas = cartas;
        }
        private void btnJogarCarta_Click_1(object sender, EventArgs e)
        {
            string retorno = Jogo.Jogar(int.Parse(txtidJogador.Text), txtsenhaJogador.Text, int.Parse(txtIdCarta.Text));
            if (retorno.Length > 4 && retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro: Valores invalidos para jogar uma carta", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtIdCarta.Text = retorno;
            txtIdCarta.Visible = true;
            ListarMao();
            ExibirJogada();
        }


        public void imgCarta(Panel carta,string n)
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
            }
        }

        public void ExibirJogada()
        {
            string retorno = Jogo.ExibirJogadas(IdPartida);
            if(retorno.Length > 4 && retorno.Substring(0,4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao verificar a rodada:","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            retorno = retorno.Replace("\r", "");
            if(retorno.Length > 0)
            {
                retorno = retorno.Substring(0, retorno.Length - 1);
            }
            string[] LJogada = retorno.Split('\n');
            string[] ultimaRodada = LJogada[LJogada.Length - 1].Split(',');
            string valor = ultimaRodada[3];
            
            int x = 300;
            lblJogadas.Text = retorno;
            lblJogadas.Visible = true;
            foreach (string j in LJogada)
            {
                string[] rodadas = j.Split(',');
                if (rodadas[0] == ultimaRodada[0])
                {
                    string c = rodadas[2];
                    string PathCard = $@"C:\Users\Star\Projeto\SistemaPI\Resources\{c}.png";

                    Panel carta = new Panel();

                    carta.BackgroundImage = Image.FromFile(PathCard);
                    carta.Height = 70;
                    carta.Width = 61;
                    carta.Left = x;
                    carta.Top = 300;

                    carta.BackgroundImageLayout = ImageLayout.Stretch;
                    this.Controls.Add(carta);
                }
                x += 100;
            }
        }
    }
}

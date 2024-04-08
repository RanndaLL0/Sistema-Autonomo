using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace SistemaPI
{
    public partial class Form1 : Form
    {
        public Point MouseLocation;
        panelCarta M;

        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }

        //Header

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        //fechar,maximizar,minimizar tela

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_click (object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //listar partidas

        private void btn_listar_Click(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();

                string retorno = Jogo.ListarPartidas("T");
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                string[] partidas = retorno.Split('\n');

                for (int i = 0; i < partidas.Length; i++)
                {
                    lstPartidas.Items.Add(partidas[i]);
                }
        }

        //listar Jogadores

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();

            string partida = lstPartidas.SelectedItem.ToString();
            string[] dadosPartidas = partida.Split(',');

            int idPartida = int.Parse(dadosPartidas[0]);
            string nomePartida = dadosPartidas[1];
            string data = dadosPartidas[2];

            label1.Text = dadosPartidas[0].ToString();
            label2.Text = nomePartida;
            label3.Text = data;
            txtID.Text = idPartida.ToString();

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno == "")
            {
                lstJogadores.Items.Add("Sem Jogadores");
                 return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            for (int i = 0; i < jogadores.Length; i++)
            {
              lstJogadores.Items.Add(jogadores[i]);
            }

        }

        //Criar Partida

        private void btnCriarPrt_Click(object sender, EventArgs e)
        {
            string nomePrt = txtNomePrt.Text;
            string senha = txtSenha.Text;

            if(nomePrt == "" || senha == "")
            {
                MessageBox.Show("Ocorreu um erro: valores invalidos para a criação", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string teste = Jogo.CriarPartida(nomePrt,senha,"Budapeste");
            if(teste == "ERRO: Nome da partida com caracteres especiais")
            {
                MessageBox.Show("Ocorreu um erro: Nome da partida com caracteres especiais", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string jogador = txtJogador.Text;
            string senha = txtSenha.Text;

            if(id == "" || senha == "" || jogador == "")
            {
               MessageBox.Show("Ocorreu um erro: Valores invalidos para entrar na partida", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            string retorno = Jogo.EntrarPartida(int.Parse(id), jogador, senha);
            retorno = retorno.Replace("\r","");
            retorno = retorno.Replace("\n", "");

            string[] infoJogador = retorno.Split(',');
            string idJogador = infoJogador[0];
            string senhaJogador = infoJogador[1];
            txtidJogador.Text = idJogador;
            txtsenhaJogador.Text = senhaJogador;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtidJogador.Text == "" || txtsenhaJogador.Text == "")
            {
                MessageBox.Show("Ocorreu um erro: Valores invalidos para criação na partida", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string senhaJogador = txtsenhaJogador.Text;
            int idJogador = int.Parse(txtidJogador.Text);
            string sorteado = Jogo.IniciarPartida(idJogador, senhaJogador);
            lblidSorteado.Visible = true;
            lblidSorteado.Text = sorteado;

        }


        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            lstCartas.Items.Clear();
            int idPartida = int.Parse(txtID.Text);
            string retorno = Jogo.ConsultarMao(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] cartas = retorno.Split('\n');

            for (int i = 0; i < cartas.Length; i++)
            {
                lstCartas.Items.Add(cartas[i]);
            }

            M = new panelCarta(cartas, idPartida);
            M.ExibirMao();
            M.Show();
        }

        public void ListarMao()
        {
            lstCartas.Items.Clear();
            int idPartida = int.Parse(txtID.Text);
            string retorno = Jogo.ConsultarMao(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] cartas = retorno.Split('\n');

            for (int i = 0; i < cartas.Length; i++)
            {
                lstCartas.Items.Add(cartas[i]);
            }
            M.Cartas = cartas;
        }

        private void btnJogarCarta_Click(object sender, EventArgs e)
        {

            string retorno = Jogo.Jogar(int.Parse(txtidJogador.Text), txtsenhaJogador.Text, int.Parse(txtIdCarta.Text));
            if (retorno.Length > 4 && retorno.Substring(0,4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro: Valores invalidos para jogar uma carta", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblValorCartaJogada.Text = retorno;
            lblValorCartaJogada.Visible = true;   
            ListarMao();
            M.ExibirMao();
            M.ExibirJogada();
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            if (txtIdCarta.Text == "")
            {
                MessageBox.Show("Ocorreu um erro: Valores invalidos para jogar uma carta", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idJogador = int.Parse(txtidJogador.Text);
            string senhaJogador = txtsenhaJogador.Text;
            int posicaoCartaJogada = int.Parse(txtIdCarta.Text);
            lblValorCartaApostada.Visible = true;
            if (posicaoCartaJogada == 0)
            {
                lblValorCartaApostada.Text = "Sem aposta";
            }
            else 
            {
            lblValorCartaApostada.Text = Jogo.Apostar(idJogador, senhaJogador, posicaoCartaJogada);
            }
        }
    }
}

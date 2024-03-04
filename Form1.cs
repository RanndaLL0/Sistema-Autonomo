using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }

        //Header

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Forms position

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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

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
        
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();

                string retorno = Jogo.ListarPartidas("T");
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                string[] partidas = retorno.Split('\n');

                for (int i = 0; i < partidas.Length - 1; i++)
                {
                    lstPartidas.Items.Add(partidas[i]);
                }
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
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

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro: " + retorno, "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            for (int i = 0; i < jogadores.Length; i++)
            {
              lstJogadores.Items.Add(jogadores[i]);
            }

        }
    }
}

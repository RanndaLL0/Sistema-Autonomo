using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPI.Entidades
{
    public class Jogador
    {
        public int Xinicial { get; set; }
        public int Yinicial { get; set; }
        public int Id { get; set; }

        public Dictionary<Panel, int> Cartas = new Dictionary<Panel, int>();

        public Jogador(int xInicial,int yinicial,int id) 
        {
            Xinicial = xInicial;
            Yinicial = yinicial;
            Id = id;
        }
    }
}

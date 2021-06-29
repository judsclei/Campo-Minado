using System;
using System.Collections.Generic;
using System.Text;

namespace Ivory.TesteEstagio.CampoMinado
{
    class IdentificaMinas
    {
        int linha, coluna;

        public IdentificaMinas (int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }
        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }
    }
}

﻿
namespace tabuleiro
{
     class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }

        public bool existePeca(Posicao pos) 
        {
            ValidarPosicao(pos);
            return peca(pos) != null;     
        }

        public Peca peca(int linha, int coluna) 
        {
            return pecas[linha,coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public void colocarPeca(Peca p, Posicao pos) 
        {
            if(existePeca(pos)) { throw new TabuleiroExceptions("Já existe uma peça nessa posição"); }

            pecas[pos.linha,pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posValida(Posicao pos) 
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
         
        public void ValidarPosicao(Posicao pos)
        {
            if (!posValida(pos))
            {
                throw new TabuleiroExceptions("Posição inválida");
            }
        }
    }
}
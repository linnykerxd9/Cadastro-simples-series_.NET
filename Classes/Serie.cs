  
using System;

namespace Dio.series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {

            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {

            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Titulo" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio" + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProdutos.Model
{
    class Produto
    {
        private static int codigo;
        private static int nomeProduto;
        private static int valorProduto;
        private static int descProduto;
        private static int quantProduto;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static int NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public static int ValorProduto { get => valorProduto; set => valorProduto = value; }
        public static int DescProduto { get => descProduto; set => descProduto = value; }
        public static int QuantProduto { get => quantProduto; set => quantProduto = value; }
        public static string Retorno { get; internal set; }
    }
}

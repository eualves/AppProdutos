using System;
using System.Collections.Generic;
using System.Text;

namespace AppProdutos.Model
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\leonardo.abico\source\repos\AppProdutos\AppProdutos\bdprodutos.mdf; Integrated Security = True";
        }
    }
}

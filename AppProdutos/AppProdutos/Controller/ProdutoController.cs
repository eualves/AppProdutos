using AppProdutos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AppProdutos.Controller
{
    class ProdutoController
    {
        public void cadastroProduto()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirProduto", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {

                comando.Parameters.AddWithValue("@nome", Produto.NomeProduto);
                comando.Parameters.AddWithValue("@valor", Produto.ValorProduto);
                comando.Parameters.AddWithValue("@descricao", Produto.DescProduto);
                comando.Parameters.AddWithValue("@quatidade", Produto.QuantProduto);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Produto cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro Produto ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Produto.Retorno = "False";
                    return;
                }
                else
                {
                    Produto.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Produto não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

    }

    public void VisuCodProduto()
    {

        SqlConnection conexao = new SqlConnection(Conexao.conectar());
        SqlCommand comandos = new SqlCommand("pBuscaCodigoProduto", conexao);
        comandos.CommandType = CommandType.StoredProcedure;

        try
        {

            comandos.Parameters.AddWithValue("@codigo", Produto.Codigo);
            conexao.Open();

            var tabelaDados = comandos.ExecuteReader();

            if (tabelaDados.Read())
            {
                Produto.NomeProduto = tabelaDados["Nome"].ToString();
                Produto.ValorProduto = tabelaDados["Valor"].ToString();
                Produto.DescProduto = tabelaDados["Descricao"].ToString();
                Produto.QuantProduto = tabelaDados["Quantidade"].ToString();
                Produto.Retorno = "True";

            }
            else
            {
                MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Produto.Retorno = "False";
            }

        }
        catch
        {
            MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        finally
        {
            if (conexao.State != ConnectionState.Closed)
            {
                conexao.Close();
            }
        }
    }

    public void AlterarProduto()
    {
        SqlConnection conexao = new SqlConnection(Conexao.conectar());
        SqlCommand comandos = new SqlCommand("pAlterarProduto", conexao);
        comandos.CommandType = CommandType.StoredProcedure;

        try
        {
            comandos.Parameters.AddWithValue("@codigo", Produto.Codigo);
            comandos.Parameters.AddWithValue("@nome", Produto.NomeProduto);
            comandos.Parameters.AddWithValue("@valor", Produto.ValorProduto);
            comandos.Parameters.AddWithValue("@descricao", Produto.DescProduto);
            comandos.Parameters.AddWithValue("@quantidade", Produto.QuantProduto);

            conexao.Open();
            comandos.ExecuteNonQuery();
            MessageBox.Show("Produto Alterado com sucesso!");
            Produto.Retorno = "True";
        }
        catch
        {
            MessageBox.Show("Produto não alterado.");
            Produto.Retorno = "False";
        }
        finally
        {
            if (conexao.State != ConnectionState.Closed)
            {
                conexao.Close();
            }
        }
    }

    public void deletarProduto()
    {
        SqlConnection conexao = new SqlConnection(Conexao.conectar());
        SqlCommand comandos = new SqlCommand("pDeletarProduto", conexao);
        comandos.CommandType = CommandType.StoredProcedure;

        try
        {
            comandos.Parameters.AddWithValue("@codigo", Produto.Codigo);
            conexao.Open();
            comandos.ExecuteNonQuery();
            Produto.Retorno = "True";
            MessageBox.Show("Produto Excluido com sucesso!");

        }
        catch
        {
            MessageBox.Show("Produto não Excluido.");
            Produto.Retorno = "False";
        }
        finally
        {
            if (conexao.State != ConnectionState.Closed)
            {
                conexao.Close();
            }
        }
    }
}





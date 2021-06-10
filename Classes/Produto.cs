using System;
using System.Collections.Generic;
using Projeto_de_objetos.Interfaces;

namespace Projeto_de_objetos.Classes
{
    public class Produto : IProduto
    {
        private int Codigo;
        private string NomeProduto;
        private float Preco;
        private string DataCadastro; 
        private Marca marca = Marca.ProdutoMarcas;
        private Usuário CadastradoPor = Usuário.LoginUsuario;
        List<Produto> ListaProdutos = new List<Produto>();
        public string Cadastrar(Produto produto)
        {
            int c = 0;
            Codigo = c;

            Console.Write("Digite o nome do seu produto: ");
            this.NomeProduto = Console.ReadLine();

            Console.Write("Digite o preco do seu produto: ");
            this.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Now.Date.ToString();

            marca.Cadastrar;

            CadastradoPor. _Nome;

            ListaProdutos.Add(produto);
            c++;
            return "Produto cadastrado com sucesso";
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.Remove(produto);
            return "Produto cadastrado com sucesso";
        }

        public void Listar()
        {
            foreach (Produto p in ListaProdutos)
            {
               Console.WriteLine($@"
                Nome: {p.NomeProduto}
                Preço: {p.Preco:C2}
                Data de Cadastro: {p.DataCadastro}
                Marca: {p.marca}
                Cadastrado por {CadastradoPor}"); 
            }
        } 
    }
}
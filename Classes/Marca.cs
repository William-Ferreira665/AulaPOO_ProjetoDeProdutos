using System;
using System.Collections.Generic;
using Projeto_de_objetos.Interfaces;

namespace Projeto_de_objetos.Classes
{
    public class Marca : IMarca
    {
         private int CodigoMarca;

        private string NomeMarca;

        private DateTime DataCadastro = DateTime.Now.Date;

        List<Marca> ListaMarcas = new List<Marca>();

        public void ProdutoMarcas(int _CodigoMarca, string _Nomemarca, string _DataCadastro){
            _CodigoMarca = CodigoMarca;
            _Nomemarca = NomeMarca;
            _DataCadastro = DataCadastro.ToString();
        }

        public string Cadastrar(Marca marca)
        {

            int C = 0;

            Console.Write($@"
            Bem vinda(o) ao Varejo 2Brothers!
            Digite o nome da Marca: ");
            NomeMarca = Console.ReadLine();

            CodigoMarca = C;

            Console.Write($@"
            Marca Cadastrada!
            Dados:
            Nome: {NomeMarca}
            Data de Cadastro: {DataCadastro}
            ");
            C++;

            return "Marca Cadastrada Com Sucesso";
        }

        public string Deletar(Marca marca)
        {
            return "Marca deletada com sucesso!";
        }

        public void Listar()
        {
            foreach (Marca item in ListaMarcas)
            {
                Console.WriteLine($@"{item.CodigoMarca} - {item.NomeMarca}");
            }
        }
    }
}
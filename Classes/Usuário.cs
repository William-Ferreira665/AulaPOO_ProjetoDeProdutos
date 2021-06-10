using System;
using Projeto_de_objetos.Interfaces;

namespace Projeto_de_objetos.Classes
{
    public class Usuário : IUsuario
    {
         private int Codigo;

        private string Nome;

        private string Email;

        private string Senha;

        private DateTime DataCadastro = DateTime.Now.Date;

         public void LoginUsuario(int _Codigo, string _Nome, string _Email, string _Senha, string _DataCadastro){
            _Codigo = Codigo;
            _Nome = Nome;
            _Email = Email;
            _Senha = Senha;
            _DataCadastro = DataCadastro.ToString();
        }

        public string Cadastrar (Usuário usuario)
        {
            int C = 0;

            Console.Write(@"
            Bem vinda(o) novo usuário ao Varejo 2Brothers!
            Digite o nome de Usuário: ");
            Nome = Console.ReadLine();

            Console.Write(@"
            Digite seu E-mail: ");
            Email = Console.ReadLine();

            Console.Write(@"
            Digite uma Senha: ");
            Senha = Console.ReadLine();

            Codigo = C;

            Console.Write($@"
            Usuário Cadastrado!
            Dados:
            Nome: {Nome}
            E-mail: {Email}
            Senha: {Senha}
            Data de Cadastro: {DataCadastro}
            ");
            C++;

            return "Usuário cadastrado com sucesso!";

        }

        public string Deletar(Usuário usuario)
        {
            
            
            return "Usuário deletado com sucesso!";
        }
    }
}
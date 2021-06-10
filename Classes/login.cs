using System;
using Projeto_de_objetos.Interfaces;

namespace Projeto_de_objetos.Classes
{
    public class login : ILogin
    {
         public string Deslogar(Usuário usuario)
        {
            throw new System.NotImplementedException();
        }

        public string Logar(Usuário usuario)
        {
            throw new System.NotImplementedException();
        }

        public string Sair(Usuário usuário)
        {
            throw new NotImplementedException();
        }

        void ILogin.Login()
        {
            throw new System.NotImplementedException();
        }
    }
}
using Projeto_de_objetos.Classes;

namespace Projeto_de_objetos.Interfaces
{
    public interface ILogin
    {
         void Login();
         string Logar(Usuário usuario);
         string Sair(Usuário usuário);
    }
}
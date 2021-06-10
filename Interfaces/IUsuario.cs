using Projeto_de_objetos.Classes;

namespace Projeto_de_objetos.Interfaces
{
    public interface IUsuario
    {
         string Cadastrar(Usuário usuario);

         string Deletar(Usuário usuario);
    }
}
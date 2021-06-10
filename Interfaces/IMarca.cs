using Projeto_de_objetos.Classes;

namespace Projeto_de_objetos.Interfaces
{
    public interface IMarca
    {
       string Cadastrar(Marca marca);

        void Listar();

        string Deletar(Marca marca);
    }
}
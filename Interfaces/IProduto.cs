using Projeto_de_objetos.Classes;

namespace Projeto_de_objetos.Interfaces
{
    public interface IProduto
    {
       string Cadastrar(Produto produto);
       void Listar();
       string Deletar(Produto produto);  
    }
}
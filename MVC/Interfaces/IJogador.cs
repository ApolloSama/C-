using System.Collections.Generic;
using MVC.Models;

namespace MVC.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);
        
        List<Jogador> LerTodos();

         void Alterar(Jogador j);

         void Deletar(int id);
    }
}
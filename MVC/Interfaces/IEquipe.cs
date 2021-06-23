using System.Collections.Generic;
using MVC.Models;

namespace MVC.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);
        List<Equipe> LerTodas();

        void Alterar(Equipe e);

        void Deletar(int id);
    }
}
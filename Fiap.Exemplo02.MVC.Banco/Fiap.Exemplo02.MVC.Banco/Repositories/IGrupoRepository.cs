using Fiap.Exemplo02.MVC.Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.MVC.Banco.Repositories
{
    public interface IGrupoRepository
    {
        void Cadastrar(Grupo aluno);
        void Atualizar(Grupo aluno);
        void Remover(int id);
        Grupo BuscarPorId(int id);
        ICollection<Grupo> Listar();
        ICollection<Grupo> BuscarPor(Expression<Func<Grupo, bool>> filtro);
    }
}

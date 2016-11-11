using Fiap.Exemplo02.MVC.Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.MVC.Banco.Repositories
{
    public interface IProfessorRepository : IGenericRepository<Professor>
    {
        void Promocao(int id, decimal valor);
    }
}

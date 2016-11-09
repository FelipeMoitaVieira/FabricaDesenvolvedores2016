using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Fiap.Exemplo02.MVC.Banco.Models;

namespace Fiap.Exemplo02.MVC.Banco.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        private PortalContext _context;

        public GrupoRepository(PortalContext context)
        {
            _context = context;
        }

        public void Atualizar(Grupo grupo)
        {
            _context.Entry(grupo).State = System.Data.Entity.EntityState.Modified;
            _context.Entry(grupo.Projeto).State = System.Data.Entity.EntityState.Modified;
        }

        public ICollection<Grupo> BuscarPor(Expression<Func<Grupo, bool>> filtro)
        {
            return _context.Grupo.Where(filtro).ToList();
        }

        public Grupo BuscarPorId(int id)
        {
            return _context.Grupo.Find(id);
        }

        public void Cadastrar(Grupo grupo)
        {
            _context.Grupo.Add(grupo);
        }

        public ICollection<Grupo> Listar()
        {
            return _context.Grupo.ToList();
        }

        public void Remover(int id)
        {
            Grupo grupo = BuscarPorId(id);
            _context.Grupo.Remove(grupo);
        }
    }
}

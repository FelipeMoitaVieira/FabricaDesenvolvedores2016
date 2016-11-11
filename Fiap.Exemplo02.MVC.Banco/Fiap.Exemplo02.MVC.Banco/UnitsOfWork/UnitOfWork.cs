using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.MVC.Banco.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {

        #region FIELDS
        private PortalContext _context = new PortalContext();

        private IGenericRepository<Aluno> _alunoRepository;

        private IGenericRepository<Grupo> _grupoRepository;

        private IProfessorRepository _professorRepository;

        #endregion

        #region GETS
        public IProfessorRepository ProfessorRepository
        {
            get
            {
                if(_professorRepository == null)
                {
                    _professorRepository = new ProfessorRepository(_context);
                }
                return _professorRepository;
            }
        }


        public IGenericRepository<Grupo> GrupoRespository
        {
            get
            {
                if(_grupoRepository == null)
                {
                    _grupoRepository = new GenericRepository<Grupo>(_context);
                }
                return _grupoRepository;
            }
            
        }


        public IGenericRepository<Aluno> AlunoRepository 
        {
            get
            {
                if(_alunoRepository == null)
                {
                    _alunoRepository = new GenericRepository<Aluno>(_context);
                }

                return _alunoRepository;
            }
            
        }

        #endregion

        #region SALVAR
        public void Salvar()
        {
            _context.SaveChanges();
        }
        #endregion

        #region DISPOSE
        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

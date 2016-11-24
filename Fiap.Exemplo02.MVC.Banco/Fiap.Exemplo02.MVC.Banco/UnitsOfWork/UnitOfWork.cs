using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.Repositories;
using System;

namespace Fiap.Exemplo02.MVC.Banco.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {

        #region FIELDS
        private PortalContext _context = new PortalContext();

        private IGenericRepository<Aluno> _alunoRepository;

        private IGenericRepository<Grupo> _grupoRepository;

        private IProfessorRepository _professorRepository;

        private IGenericRepository<Projeto> _projetoRepository;

        private IGenericRepository<Endereco> _enderecoRepository;

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

        public IGenericRepository<Endereco> EnderecoRepository
        {
            get
            {
                if (_enderecoRepository == null)
                {
                    _enderecoRepository = new GenericRepository<Endereco>(_context);
                }
                return _enderecoRepository;
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

        public IGenericRepository<Projeto> ProjetoRepository
        {
            get
            {
                if(_projetoRepository == null)
                {
                    _projetoRepository = new GenericRepository<Projeto>(_context);
                }
                return _projetoRepository;
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

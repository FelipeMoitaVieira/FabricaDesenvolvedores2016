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

        private PortalContent _context = new PortalContent();

        private AlunoRepository _alunoRepository;

        private GrupoRepository _grupoRepository;

        public GrupoRepository GrupoRespository
        {
            get
            {
                if(_grupoRepository == null)
                {
                    _grupoRepository = new GrupoRepository(_context);
                }
                return _grupoRepository;
            }
            
        }


        public AlunoRepository AlunoRepository 
        {
            get
            {
                if(_alunoRepository == null)
                {
                    _alunoRepository = new AlunoRepository(_context);
                }

                return _alunoRepository;
            }
            
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        
        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}

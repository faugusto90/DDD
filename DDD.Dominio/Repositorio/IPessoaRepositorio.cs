using DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominio.Repositorio
{
    public interface IPessoaRepositorio : IDisposable
    {
        IQueryable<Pessoa> Query();
        void Save(Pessoa entity);
        bool VerificarExiste(Pessoa pessoa);        
    }
}

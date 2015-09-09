using DDD.Dominio.Entidades;
using DDD.Dominio.Repositorio;
using DDD.Dominio.Specs;
using DDD.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        Contexto ctx;

        public PessoaRepositorio()
        {
            ctx = new Contexto();
        }
        public IQueryable<Pessoa> Query()
        {
            return ctx.Pessoa;
        }

        public void Save(Pessoa entity)
        {
            ctx.Pessoa.Add(entity);

            ctx.SaveChanges();
        }

        public bool VerificarExiste(Pessoa pessoa)
        {
            return ctx.Pessoa.Any(PessoaSpecs.IsNomeIgual(pessoa.Nome));
        }

        public void Dispose()
        {
            this.ctx.Dispose();
        }
    }
}

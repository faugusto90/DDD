using DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominio.Specs
{
    public static class PessoaSpecs
    {
        public static Expression<Func<Pessoa, bool>> IsNomeIgual(string username)
        {
            return x => x.Nome == username;
        }

        public static Expression<Func<Pessoa, bool>> IsMaiorIdade()
        {
            return x => x.Idade >= 18;
        }
    }
}

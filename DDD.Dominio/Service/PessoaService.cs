using DDD.Dominio.Entidades;
using DDD.Dominio.Repositorio;
using DDD.Dominio.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominio.Service
{
    public class PessoaService
    {
        IPessoaRepositorio repositorio;

        public PessoaService(IPessoaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        void Cadastrar(Pessoa pessoa)
        {
            new PessoaCadastroValidator(repositorio).Validate(pessoa);

            repositorio.Save(pessoa);
        }
    }
}

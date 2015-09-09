using DDD.Dominio.Entidades;
using DDD.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominio.Validators
{
    public class PessoaCadastroValidator : BaseValidator
    {
        IPessoaRepositorio repositorio;

        public PessoaCadastroValidator(IPessoaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Validate(Pessoa entity)
        {
            if (String.IsNullOrEmpty(entity.Nome))
            {
                Exception ex = new ArgumentNullException("O Nome não pode ser nulo ou vazio");

                AddError(ex);
            }

            if (entity.Idade < 18)
            {
                Exception ex = new ArgumentOutOfRangeException("A idade deve ser maior que 18 anos");
                AddError(ex);
            }

            if (repositorio.VerificarExiste(entity))
            {
                Exception ex = new Exception("Usuario já existe");
                AddError(ex);
            }

            RaiseErrors();
        }
    }
}

using DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Context
{
    internal class Contexto : DbContext
    {
        public Contexto()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Pessoa> Pessoa { get; set; }

    }
}

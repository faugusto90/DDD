using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominio.Validators
{
    public abstract class BaseValidator
    {
        List<Exception> exceptions = new List<Exception>();

        public void AddError(Exception ex)
        {
            exceptions.Add(ex);
        }

        public void RaiseErrors()
        {
            if (exceptions.Count > 0)
            {
                AggregateException aggregate = new AggregateException(exceptions);
                throw aggregate;
            }
        }
    }
}

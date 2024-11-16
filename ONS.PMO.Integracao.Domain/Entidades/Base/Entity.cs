using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Entidades.Base
{
    public class Entity<T>
    {
        public virtual T Id { get; set; }

    }
}

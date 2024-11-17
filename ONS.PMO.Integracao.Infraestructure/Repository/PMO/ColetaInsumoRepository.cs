﻿using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Infraestructure.Repository.PMO
{
    public class ColetaInsumoRepository : Repository<ColetaInsumo>, IColetaInsumoRepository
    {
        public ColetaInsumoRepository(WebPmoContext context) : base(context)
        {
        }
    }
}

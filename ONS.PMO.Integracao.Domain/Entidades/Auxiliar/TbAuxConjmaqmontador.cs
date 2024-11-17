using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxConjmaqmontador
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdGruge { get; set; }

    public string NomCurtousina { get; set; } = null!;

    public int CodDppusina { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}

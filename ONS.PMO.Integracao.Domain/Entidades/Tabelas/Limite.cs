using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Limite
{
    public int IdTplimite { get; set; }

    public string DscTplimite { get; set; } = null!;

    public virtual ICollection<ColunaGrandeza> TbColunagrandezas { get; set; } = new List<ColunaGrandeza>();

    public virtual ICollection<DadoColetaEstruturado> TbDadocoletaestruturados { get; set; } = new List<DadoColetaEstruturado>();
}

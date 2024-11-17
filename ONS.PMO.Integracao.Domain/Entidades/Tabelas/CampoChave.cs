using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class CampoChave
{
    public int IdCampochave { get; set; }

    public string CodCampochave { get; set; } = null!;

    public string DscCampochave { get; set; } = null!;

    public virtual ICollection<CampoChaveTipoColeta> TbCampochavetpcoleta { get; set; } = new List<CampoChaveTipoColeta>();

    public virtual ICollection<ChaveBloco> TbChaveblocos { get; set; } = new List<ChaveBloco>();

    public virtual ICollection<ChaveMnemonico> TbChavemnemonicos { get; set; } = new List<ChaveMnemonico>();

    public virtual ICollection<OrdenacaoRegistro> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistro>();

    public virtual ICollection<ModificacaoConfiguracaoBlocoEstudo> IdModifconfigblocoestudos { get; set; } = new List<ModificacaoConfiguracaoBlocoEstudo>();
}

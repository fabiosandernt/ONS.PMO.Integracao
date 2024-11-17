using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ManutencaoProgramada
{
    public int IdManutencaoprogramada { get; set; }

    public int IdTpmanutencaoprogramada { get; set; }

    public int? IdOrigemuge { get; set; }

    public int? IdOrigemusi { get; set; }

    public int IdAgenteInstituicao { get; set; }

    public int IdEstudomontador { get; set; }

    public DateTime DinInicio { get; set; }

    public DateTime DinTermino { get; set; }

    public string DscJustificativa { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual AgenteInstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbAuxUnidadegeradoramontador? IdOrigemugeNavigation { get; set; }

    public virtual TbAuxUsinamontador? IdOrigemusiNavigation { get; set; }

    public virtual TipoManutencaoProgramada IdTpmanutencaoprogramadaNavigation { get; set; } = null!;
}

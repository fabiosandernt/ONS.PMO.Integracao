using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ManutencaoPrograma
{
    public int IdManutencaoprogramada { get; set; }

    public int IdTpmanutencaoprogramada { get; set; }

    public int? IdOrigemuge { get; set; }

    public int? IdOrigemusi { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public int IdEstudomontador { get; set; }

    public DateTime DinInicio { get; set; }

    public DateTime DinTermino { get; set; }

    public string DscJustificativa { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual Agenteinstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual AuxUnidadeGeradoraMontador? IdOrigemugeNavigation { get; set; }

    public virtual AuxUsinaMontador? IdOrigemusiNavigation { get; set; }

    public virtual ManutencaoProgramadum IdTpmanutencaoprogramadaNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class ColetaInsumo
{
    public int IdColetainsumo { get; set; }

    public int IdTpsituacaocoletainsumo { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdInsumopmo { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public string? DscMotivoalteracaoons { get; set; }

    public string? DscMotivorejeicaoons { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    public string? LgnAgenteultimaalteracao { get; set; }

    public string? CodPerfilons { get; set; }

    public string? NomGrandezasnaoestagioalteradas { get; set; }

    public virtual Agenteinstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual InsumoPMO IdInsumopmoNavigation { get; set; } = null!;

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual SituacaoColetaInsumo IdTpsituacaocoletainsumoNavigation { get; set; } = null!;

    public virtual ICollection<DadoColeta> TbDadocoleta { get; set; } = new List<DadoColeta>();

    public virtual ICollection<HistoricoColetaInsumo> TbHistmodifcoletainsumos { get; set; } = new List<HistoricoColetaInsumo>();
}

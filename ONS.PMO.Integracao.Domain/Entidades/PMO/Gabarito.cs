using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class Gabarito
{
    public int IdGabarito { get; set; }

    public int IdInsumopmo { get; set; }

    public bool FlgPadrao { get; set; }

    public string? CodPerfilons { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? IdOrigemcoleta { get; set; }

    public int? IdAgenteinstituicao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual Agenteinstituicao? IdAgenteinstituicaoNavigation { get; set; }

    public virtual InsumoPMO IdInsumopmoNavigation { get; set; } = null!;

    public virtual OrigemColetum? IdOrigemcoletaNavigation { get; set; }

    public virtual SemanaOperativa? IdSemanaoperativaNavigation { get; set; }

    public virtual ICollection<DadoColeta> TbDadocoleta { get; set; } = new List<DadoColeta>();
}

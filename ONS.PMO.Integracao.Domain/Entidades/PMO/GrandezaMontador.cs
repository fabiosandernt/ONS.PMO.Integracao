using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class GrandezaMontador
{
    public int IdGrandezamontador { get; set; }

    public int? IdTpdadograndeza { get; set; }

    public string NomGrandezamontador { get; set; } = null!;

    public string CodGrandezamontador { get; set; } = null!;

    public string? DscGrandezamontador { get; set; }

    public bool FlgAceitavalornegativo { get; set; }

    public bool FlgObrigatorio { get; set; }

    public bool FlgAtivo { get; set; }

    public bool FlgComentario { get; set; }

    public bool FlgDecimaisexatos { get; set; }

    public int? QtdDigitos { get; set; }

    public int? QtdDecimais { get; set; }

    public string? FlgRecuperaestudos { get; set; }

    public bool FlgMotivoalteracao { get; set; }

    public virtual DadoGrandeza? IdTpdadograndezaNavigation { get; set; }

    public virtual GrandezaBloco? TbGrandezabloco { get; set; }

    public virtual GrandezaBlocoAC? TbGrandezablocoac { get; set; }

    public virtual ICollection<HistoricoConfiguracaoGrandeza> TbHisconfiggrandezas { get; set; } = new List<HistoricoConfiguracaoGrandeza>();
}

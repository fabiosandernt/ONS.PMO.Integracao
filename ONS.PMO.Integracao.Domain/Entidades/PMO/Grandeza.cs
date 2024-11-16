using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class Grandeza
{
    public int IdGrandeza { get; set; }

    public int IdInsumopmo { get; set; }

    public string NomGrandeza { get; set; } = null!;

    public short NumOrdemexibicao { get; set; }

    public bool FlgColetaporpatamar { get; set; }

    public bool FlgColetaporlimite { get; set; }

    public bool FlgColetaporestagio { get; set; }

    public bool FlgAceitavalornegativo { get; set; }

    public bool FlgPoderecuperarvalor { get; set; }

    public bool FlgDestacadiferenca { get; set; }

    public bool FlgAtivo { get; set; }

    public int IdTpdadograndeza { get; set; }

    public int? QtdDigitos { get; set; }

    public int? QtdDecimais { get; set; }

    public bool? FlgParticipablocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public bool? FlgObrigatoriedade { get; set; }

    public bool FlgPreaprovadocomalteracao { get; set; }

    public virtual InsumoEstruturado IdInsumopmoNavigation { get; set; } = null!;

    public virtual DadoGrandeza IdTpdadograndezaNavigation { get; set; } = null!;

    public virtual ICollection<DadoColeta> TbDadocoleta { get; set; } = new List<DadoColeta>();

    public virtual ICollection<GrandezaBloco> TbGrandezablocos { get; set; } = new List<GrandezaBloco>();
}

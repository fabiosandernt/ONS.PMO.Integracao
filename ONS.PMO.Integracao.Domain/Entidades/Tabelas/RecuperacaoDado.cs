using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class RecuperacaoDado
{
    public int IdRecuperacaodados { get; set; }

    public int? IdEstudomontadorfonte { get; set; }

    public string? NomArquivofonte { get; set; }

    public int? IdSemanaoperativafonte { get; set; }

    public bool FlgInserirchaves { get; set; }

    public int IdEstudomontadordestino { get; set; }

    public string LgnUsuario { get; set; } = null!;

    public DateTime DinRecuperacao { get; set; }

    public virtual EstudoMontador IdEstudomontadordestinoNavigation { get; set; } = null!;

    public virtual EstudoMontador? IdEstudomontadorfonteNavigation { get; set; }

    public virtual SemanaOperativa? IdSemanaoperativafonteNavigation { get; set; }

    public virtual ICollection<RecuperacaoDadosAgentePmo> TbRecuperacaodadosagentepmos { get; set; } = new List<RecuperacaoDadosAgentePmo>();

    public virtual ICollection<RecuperacaoDadosBloco> TbRecuperacaodadosblocos { get; set; } = new List<RecuperacaoDadosBloco>();
}

using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaMontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurto { get; set; } = null!;

    public int CodDpp { get; set; }

    public string? IdAge { get; set; }

    public string? NomCurtosubsistema { get; set; }

    public string CodSubsistema { get; set; } = null!;

    public int? NumRestricao { get; set; }

    public string IdTpusina { get; set; } = null!;

    public string? NomCurtoree { get; set; }

    public int? CodRee { get; set; }

    public string? CodTpgeracao { get; set; }

    public string? NomLongo { get; set; }

    public int? IdResjusante { get; set; }

    public string? IdOrigemcoletamontadorree { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxDesvioAgua> TbAuxDesvioaguaIdUsinamontadorretiradaNavigations { get; set; } = new List<AuxDesvioAgua>();

    public virtual ICollection<AuxDesvioAgua> TbAuxDesvioaguaIdUsinamontadorretornoNavigations { get; set; } = new List<AuxDesvioAgua>();

    public virtual ICollection<AuxUnidadeGeradoraMontador> TbAuxUnidadegeradoramontadors { get; set; } = new List<AuxUnidadeGeradoraMontador>();

    public virtual ICollection<AuxUsinaConjunto> TbAuxUsinaconjuntos { get; set; } = new List<AuxUsinaConjunto>();

    public virtual ICollection<AuxUsinaMnemonico> TbAuxUsinamnemonicos { get; set; } = new List<AuxUsinaMnemonico>();

    public virtual ICollection<DecisaoComandoGNL> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNL>();

    public virtual ICollection<ManutencaoPrograma> TbManutencaoprogramada { get; set; } = new List<ManutencaoPrograma>();

    public virtual ICollection<ConjuntoGeracaoMinima> IdConjuntogeracaominimas { get; set; } = new List<ConjuntoGeracaoMinima>();
}

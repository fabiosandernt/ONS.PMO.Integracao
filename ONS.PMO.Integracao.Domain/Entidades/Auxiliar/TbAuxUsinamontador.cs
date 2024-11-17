using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUsinamontador
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

    public virtual ICollection<TbAuxDesvioagua> TbAuxDesvioaguaIdUsinamontadorretiradaNavigations { get; set; } = new List<TbAuxDesvioagua>();

    public virtual ICollection<TbAuxDesvioagua> TbAuxDesvioaguaIdUsinamontadorretornoNavigations { get; set; } = new List<TbAuxDesvioagua>();

    public virtual ICollection<TbAuxUnidadegeradoramontador> TbAuxUnidadegeradoramontadors { get; set; } = new List<TbAuxUnidadegeradoramontador>();

    public virtual ICollection<TbAuxUsinaconjunto> TbAuxUsinaconjuntos { get; set; } = new List<TbAuxUsinaconjunto>();

    public virtual ICollection<TbAuxUsinamnemonico> TbAuxUsinamnemonicos { get; set; } = new List<TbAuxUsinamnemonico>();

    public virtual ICollection<DecisaoComandoGNL> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNL>();

    public virtual ICollection<ManutencaoProgramada> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramada>();

    public virtual ICollection<ConjuntoGeracaoMinima> IdConjuntogeracaominimas { get; set; } = new List<ConjuntoGeracaoMinima>();
}

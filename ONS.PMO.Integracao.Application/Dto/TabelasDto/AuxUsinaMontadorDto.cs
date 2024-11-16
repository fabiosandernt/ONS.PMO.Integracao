using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxUsinaMontadorDto
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

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxDesvioAguaDto> TbAuxDesvioaguaIdUsinamontadorretiradaNavigations { get; set; } = new List<AuxDesvioAguaDto>();

    public virtual ICollection<AuxDesvioAguaDto> TbAuxDesvioaguaIdUsinamontadorretornoNavigations { get; set; } = new List<AuxDesvioAguaDto>();

    public virtual ICollection<AuxUnidadeGeradoraMontadorDto> TbAuxUnidadegeradoramontadors { get; set; } = new List<AuxUnidadeGeradoraMontadorDto>();

    public virtual ICollection<AuxUsinaConjuntoDto> TbAuxUsinaconjuntos { get; set; } = new List<AuxUsinaConjuntoDto>();

    public virtual ICollection<AuxUsinaMnemonicoDto> TbAuxUsinamnemonicos { get; set; } = new List<AuxUsinaMnemonicoDto>();

    public virtual ICollection<DecisaoComandoGNLDto> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNLDto>();

    public virtual ICollection<ManutencaoProgramadaDto> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramadaDto>();

    public virtual ICollection<ConjuntoGeracaoMinimaDto> IdConjuntogeracaominimas { get; set; } = new List<ConjuntoGeracaoMinimaDto>();
}

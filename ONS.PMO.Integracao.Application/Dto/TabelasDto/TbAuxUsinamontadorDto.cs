using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUsinamontadorDto
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

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxDesvioaguaDto> TbAuxDesvioaguaIdUsinamontadorretiradaNavigations { get; set; } = new List<TbAuxDesvioaguaDto>();

    public virtual ICollection<TbAuxDesvioaguaDto> TbAuxDesvioaguaIdUsinamontadorretornoNavigations { get; set; } = new List<TbAuxDesvioaguaDto>();

    public virtual ICollection<TbAuxUnidadegeradoramontadorDto> TbAuxUnidadegeradoramontadors { get; set; } = new List<TbAuxUnidadegeradoramontadorDto>();

    public virtual ICollection<TbAuxUsinaconjuntoDto> TbAuxUsinaconjuntos { get; set; } = new List<TbAuxUsinaconjuntoDto>();

    public virtual ICollection<TbAuxUsinamnemonicoDto> TbAuxUsinamnemonicos { get; set; } = new List<TbAuxUsinamnemonicoDto>();

    public virtual ICollection<TbDecisaocomandognlDto> TbDecisaocomandognls { get; set; } = new List<TbDecisaocomandognlDto>();

    public virtual ICollection<TbManutencaoprogramadumDto> TbManutencaoprogramada { get; set; } = new List<TbManutencaoprogramadumDto>();

    public virtual ICollection<TbConjuntogeracaominimaDto> IdConjuntogeracaominimas { get; set; } = new List<TbConjuntogeracaominimaDto>();
}

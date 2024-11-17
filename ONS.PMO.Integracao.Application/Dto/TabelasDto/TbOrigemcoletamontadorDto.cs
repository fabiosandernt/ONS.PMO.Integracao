using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbOrigemcoletamontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdTpcoleta { get; set; }

    public string? CodOrigemcoletamontador { get; set; }

    public string NomExibicao { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[]? VerControleconcorrencia { get; set; }

    public bool FlgAtivo { get; set; }

    public DateTime DinIniciovalidade { get; set; }

    public DateTime? DinTerminovalidade { get; set; }

    public virtual TbTpcoletumDto IdTpcoletaNavigation { get; set; } = null!;

    public virtual TbAuxConjmaqmontadorDto? TbAuxConjmaqmontador { get; set; }

    public virtual TbAuxDesvioaguaDto? TbAuxDesvioagua { get; set; }

    public virtual TbAuxInterligacaomontadorDto? TbAuxInterligacaomontador { get; set; }

    public virtual ICollection<TbAuxInterligacaomontadorinterligacaoDto> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<TbAuxInterligacaomontadorinterligacaoDto>();

    public virtual ICollection<TbAuxInterligacaomontadorusinaDto> TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations { get; set; } = new List<TbAuxInterligacaomontadorusinaDto>();

    public virtual ICollection<TbAuxInterligacaomontadorusinaDto> TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations { get; set; } = new List<TbAuxInterligacaomontadorusinaDto>();

    public virtual TbAuxMnemonicomontadorDto? TbAuxMnemonicomontador { get; set; }

    public virtual TbAuxPequenausinaDto? TbAuxPequenausina { get; set; }

    public virtual TbAuxReemontadorDto? TbAuxReemontador { get; set; }

    public virtual TbAuxSubmercadoDto? TbAuxSubmercado { get; set; }

    public virtual TbAuxSubsistemacontratoDto? TbAuxSubsistemacontrato { get; set; }

    public virtual TbAuxSubsistemaintervalocustodeficitDto? TbAuxSubsistemaintervalocustodeficit { get; set; }

    public virtual TbAuxSubsistemamontadorDto? TbAuxSubsistemamontador { get; set; }

    public virtual TbAuxUnidadegeradoramontadorDto? TbAuxUnidadegeradoramontador { get; set; }

    public virtual TbAuxUsinaconjuntoDto? TbAuxUsinaconjunto { get; set; }

    public virtual TbAuxUsinamnemonicoDto? TbAuxUsinamnemonico { get; set; }

    public virtual TbAuxUsinamontadorDto? TbAuxUsinamontador { get; set; }

    public virtual ICollection<TbChaveblocoestudoDto> TbChaveblocoestudos { get; set; } = new List<TbChaveblocoestudoDto>();

    public virtual ICollection<TbChavemnemonicoestudoDto> TbChavemnemonicoestudos { get; set; } = new List<TbChavemnemonicoestudoDto>();

    public virtual ICollection<TbGrandezablocoestudoDto> TbGrandezablocoestudos { get; set; } = new List<TbGrandezablocoestudoDto>();

    public virtual ICollection<TbGrandezamnemonicoestudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<TbGrandezamnemonicoestudoDto>();
}

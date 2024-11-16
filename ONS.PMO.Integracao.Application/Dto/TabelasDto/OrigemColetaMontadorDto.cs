using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class OrigemColetaMontadorDto
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

    public virtual ColetumDto IdTpcoletaNavigation { get; set; } = null!;

    public virtual AuxConjMaquinaMontadorDto? TbAuxConjmaqmontador { get; set; }

    public virtual AuxDesvioAguaDto? TbAuxDesvioagua { get; set; }

    public virtual AuxInterligacaoMontadorDto? TbAuxInterligacaomontador { get; set; }

    public virtual ICollection<AuxInterligacaoMontadorInterligacaoDto> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<AuxInterligacaoMontadorInterligacaoDto>();

    public virtual ICollection<AuxInterligacaoMontadorUsinaDto> TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations { get; set; } = new List<AuxInterligacaoMontadorUsinaDto>();

    public virtual ICollection<AuxInterligacaoMontadorUsinaDto> TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations { get; set; } = new List<AuxInterligacaoMontadorUsinaDto>();

    public virtual AuxMnemonicoMontadorDto? TbAuxMnemonicomontador { get; set; }

    public virtual AuxPequenaUsinaDto? TbAuxPequenausina { get; set; }

    public virtual AuxReeMontadorDto? TbAuxReemontador { get; set; }

    public virtual AuxSubmercadoDto? TbAuxSubmercado { get; set; }

    public virtual AuxSubsistemaContratoDto? TbAuxSubsistemacontrato { get; set; }

    public virtual AuxSubsistemaIntervaloCustoDeficitDto? TbAuxSubsistemaintervalocustodeficit { get; set; }

    public virtual AuxSubsistemaMontadorDto? TbAuxSubsistemamontador { get; set; }

    public virtual AuxUnidadeGeradoraMontadorDto? TbAuxUnidadegeradoramontador { get; set; }

    public virtual AuxUsinaConjuntoDto? TbAuxUsinaconjunto { get; set; }

    public virtual AuxUsinaMnemonicoDto? TbAuxUsinamnemonico { get; set; }

    public virtual AuxUsinaMontadorDto? TbAuxUsinamontador { get; set; }

    public virtual ICollection<ChaveBlocoEstudoDto> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudoDto>();

    public virtual ICollection<ChaveMnemonicoEstudoDto> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudoDto>();

    public virtual ICollection<GrandezaBlocoEstudoDto> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudoDto>();

    public virtual ICollection<GrandezaMnemonicoEstudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudoDto>();
}

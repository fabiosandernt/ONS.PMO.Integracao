using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class OrigemColetaMontador
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

    public virtual Coleta IdTpcoletaNavigation { get; set; } = null!;

    public virtual TbAuxConjmaqmontador? TbAuxConjmaqmontador { get; set; }

    public virtual TbAuxDesvioagua? TbAuxDesvioagua { get; set; }

    public virtual TbAuxInterligacaomontador? TbAuxInterligacaomontador { get; set; }

    public virtual ICollection<TbAuxInterligacaomontadorinterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<TbAuxInterligacaomontadorinterligacao>();

    public virtual ICollection<TbAuxInterligacaomontadorusina> TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations { get; set; } = new List<TbAuxInterligacaomontadorusina>();

    public virtual ICollection<TbAuxInterligacaomontadorusina> TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations { get; set; } = new List<TbAuxInterligacaomontadorusina>();

    public virtual TbAuxMnemonicomontador? TbAuxMnemonicomontador { get; set; }

    public virtual TbAuxPequenausina? TbAuxPequenausina { get; set; }

    public virtual TbAuxReemontador? TbAuxReemontador { get; set; }

    public virtual TbAuxSubmercado? TbAuxSubmercado { get; set; }

    public virtual TbAuxSubsistemacontrato? TbAuxSubsistemacontrato { get; set; }

    public virtual TbAuxSubsistemaintervalocustodeficit? TbAuxSubsistemaintervalocustodeficit { get; set; }

    public virtual TbAuxSubsistemamontador? TbAuxSubsistemamontador { get; set; }

    public virtual TbAuxUnidadegeradoramontador? TbAuxUnidadegeradoramontador { get; set; }

    public virtual TbAuxUsinaconjunto? TbAuxUsinaconjunto { get; set; }

    public virtual TbAuxUsinamnemonico? TbAuxUsinamnemonico { get; set; }

    public virtual TbAuxUsinamontador? TbAuxUsinamontador { get; set; }

    public virtual ICollection<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudo>();

    public virtual ICollection<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudo>();

    public virtual ICollection<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudo>();

    public virtual ICollection<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudo>();
}

using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class OrigemColetaMontador
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

    public virtual AuxConjMaquinaMontador? TbAuxConjmaqmontador { get; set; }

    public virtual AuxDesvioAgua? TbAuxDesvioagua { get; set; }

    public virtual AuxInterligacaoMontador? TbAuxInterligacaomontador { get; set; }

    public virtual ICollection<AuxInterligacaoMontadorInterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<AuxInterligacaoMontadorInterligacao>();

    public virtual ICollection<AuxInterligacaoMontadorUsina> TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations { get; set; } = new List<AuxInterligacaoMontadorUsina>();

    public virtual ICollection<AuxInterligacaoMontadorUsina> TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations { get; set; } = new List<AuxInterligacaoMontadorUsina>();

    public virtual AuxMnemonicoMontador? TbAuxMnemonicomontador { get; set; }

    public virtual AuxPequenaUsina? TbAuxPequenausina { get; set; }

    public virtual AuxReeMontador? TbAuxReemontador { get; set; }

    public virtual AuxSubmercado? TbAuxSubmercado { get; set; }

    public virtual AuxSubsistemaContrato? TbAuxSubsistemacontrato { get; set; }

    public virtual AuxSubsistemaIntervaloCustoDeficit? TbAuxSubsistemaintervalocustodeficit { get; set; }

    public virtual AuxSubsistemaMontador? TbAuxSubsistemamontador { get; set; }

    public virtual AuxUnidadeGeradoraMontador? TbAuxUnidadegeradoramontador { get; set; }

    public virtual AuxUsinaConjunto? TbAuxUsinaconjunto { get; set; }

    public virtual AuxUsinaMnemonico? TbAuxUsinamnemonico { get; set; }

    public virtual AuxUsinaMontador? TbAuxUsinamontador { get; set; }

    public virtual ICollection<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudo>();

    public virtual ICollection<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudo>();

    public virtual ICollection<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudo>();

    public virtual ICollection<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudo>();
}

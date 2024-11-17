using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ConjuntoGeracaoMinima
{
    public int IdConjuntogeracaominima { get; set; }

    public int IdEstudomontador { get; set; }

    public string NomConjuntogeracaominima { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string LgnUltimaalteracao { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<Desligamento> TbDesligamentos { get; set; } = new List<Desligamento>();

    public virtual ICollection<GeracaoMinimaPeriodoDia> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodoDia>();

    public virtual ICollection<TbAuxUsinamontador> IdOrigemcoletamontadors { get; set; } = new List<TbAuxUsinamontador>();
}

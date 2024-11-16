using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxInterligacao
{
    public int IdInterligacao { get; set; }

    public int IdIntercambiopdes { get; set; }

    public string NomIntercambiopdes { get; set; } = null!;

    public virtual ICollection<AuxInterligacaoMontadorInterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<AuxInterligacaoMontadorInterligacao>();
}

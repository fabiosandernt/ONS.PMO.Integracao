using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxInterligacao
{
    public int IdInterligacao { get; set; }

    public int IdIntercambiopdes { get; set; }

    public string NomIntercambiopdes { get; set; } = null!;

    public virtual ICollection<TbAuxInterligacaomontadorinterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<TbAuxInterligacaomontadorinterligacao>();
}

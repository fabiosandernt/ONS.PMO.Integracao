using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class ParametroPMO
{
    public int IdParametropmo { get; set; }

    public string NomParametropmo { get; set; } = null!;

    public string? ValParametropmo { get; set; }

    public string? DscParametropmo { get; set; }
}

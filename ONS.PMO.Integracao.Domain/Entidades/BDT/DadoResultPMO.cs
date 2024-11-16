using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class DadoResultPMO
{
    public int IdDadoresultpmo { get; set; }

    public int IdMnemonicopmo { get; set; }

    public int IdListaresultadopmo { get; set; }

    public int? IdTppatamar { get; set; }
    public string Tppatamar { get; set; }

    public string DscValorcoletadomnemonico { get; set; } = null!;

    public bool? FlgValoroficial { get; set; }

    public int? NumEstagio { get; set; }

    public virtual ListaResultadoPMO IdListaresultadopmoNavigation { get; set; } = null!;

    public virtual MnemonicoPMO IdMnemonicopmoNavigation { get; set; } = null!;
}

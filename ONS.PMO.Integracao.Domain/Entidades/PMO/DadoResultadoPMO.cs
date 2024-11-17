using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoResultadoPMO
{
    public int IdDadoresultpmo { get; set; }

    public int IdMnemonicopmo { get; set; }

    public int IdListaresultadopmo { get; set; }

    public int? IdTppatamar { get; set; }
    public string Tppatamar { get; set; }

    public string DscValorcoletadomnemonico { get; set; } = null!;

    public bool? FlgValoroficial { get; set; }

    public int? NumEstagio { get; set; }

    public virtual ListaResultadoPmo IdListaresultadopmoNavigation { get; set; } = null!;

    public virtual MnemonicoPmo IdMnemonicopmoNavigation { get; set; } = null!;
}

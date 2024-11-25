﻿using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Application.Dto.PMO;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

/// <summary>
/// Associação de arquivos encaminhados por semana operativa 
/// </summary>
public  class TbArquivosemanaoperativaDto
{
    /// <summary>
    /// Identificador do arquivo da semana operativa
    /// </summary>
    public int IdArquivosemanaoperativa { get; set; }

    /// <summary>
    /// Identificadorda semana operativa do programa mensal de operação - PMO
    /// </summary>
    public int IdSemanaoperativa { get; set; }

    /// <summary>
    /// Identificador dos arquivos que contém insumos para o sistema
    /// </summary>
    public Guid IdArquivo { get; set; }

    /// <summary>
    /// Identificador da situação da semana operativado. Possíveis valores: Configuração, Coleta de dados, Geração de blocos, Convergência CCEE e Publicado
    /// </summary>
    public int IdTpsituacaosemanaoper { get; set; }

    /// <summary>
    /// Indica se o arquivo associado a semana operativa foi publicado
    /// </summary>
    public bool FlgPublicado { get; set; }

    public virtual TbArquivoDto IdArquivoNavigation { get; set; } = null!;

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual TbTpsituacaosemanaoperDto IdTpsituacaosemanaoperNavigation { get; set; } = null!;
}

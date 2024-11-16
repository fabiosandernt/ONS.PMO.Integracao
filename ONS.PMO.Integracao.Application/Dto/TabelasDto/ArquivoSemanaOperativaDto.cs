using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

/// <summary>
/// Associação de arquivos encaminhados por semana operativa 
/// </summary>
public  class ArquivoSemanaOperativaDto
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

    public virtual ArquivoDto IdArquivoNavigation { get; set; } = null!;

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual SituacaoSemanaOperativaDto IdTpsituacaosemanaoperNavigation { get; set; } = null!;
}

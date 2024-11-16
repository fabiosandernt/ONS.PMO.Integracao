using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas
{
    public class ArquivoExportacao
    {
        public int IdArquivoexportacao { get; set; }

        public string NomArquivoexportacao { get; set; } = null!;

        public string? DscArquivoexportacao { get; set; }

        public virtual ICollection<Bloco> TbBlocos { get; set; } = new List<Bloco>();

        public virtual ICollection<ExportacaoArquivoTexto> TbExportacaoarquivotextos { get; set; } = new List<ExportacaoArquivoTexto>();
    }
}



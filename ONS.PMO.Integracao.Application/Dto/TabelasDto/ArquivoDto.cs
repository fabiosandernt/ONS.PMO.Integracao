using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto
{

    /// <summary>
    /// Tem o propósito geral de armazena dados sobre um arquivo, que poderá ser referenciado por outras dados do sistema.
    /// </summary>
    public  class ArquivoDto
    {
        /// <summary>
        /// Identificador dos arquivos que contém insumos para o sistema
        /// </summary>
        public Guid IdArquivo { get; set; }

        /// <summary>
        /// Conteúdo do arquivo
        /// </summary>
        public byte[] ArqConteudo { get; set; } = null!;

        /// <summary>
        /// Tipo do arquivo (MimeType), segundo a nomenclatura padrão da IANA
        /// </summary>
        public string DscMimearquivo { get; set; } = null!;

        /// <summary>
        /// Código Hash de verificação do arquivo (uso interno) para garantir a consistencia do arquivo
        /// </summary>
        public string CodHashverificacao { get; set; } = null!;

        /// <summary>
        /// Nome do Arquivo com Extensão
        /// </summary>
        public string NomArquivo { get; set; } = null!;

        /// <summary>
        /// Tamanho em bytes do arquivo
        /// </summary>
        public int NumTamanhoarquivo { get; set; }

        /// <summary>
        /// Indica se o arquivo foi excluído logicamente
        /// </summary>
        public bool? FlgExcluido { get; set; }

        public virtual ICollection<ArquivoSemanaOperativaDto> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativaDto>();

        public virtual ICollection<DadoColetanaoEstruturadoDto> IdDadocoleta { get; set; } = new List<DadoColetanaoEstruturadoDto>();
    }

}

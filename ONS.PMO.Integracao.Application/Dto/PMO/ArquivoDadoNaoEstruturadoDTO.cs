using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ArquivoDadoNaoEstruturadoDTO
    {
        public String CaminhoFisicoCompleto { get; set; }

        public String Nome { get; set; }

        public Guid Id { get; set; }

        public String MimeType { get; set; }

        public int Tamanho { get; set; }

        public int TamanhoEmKb { get { return Tamanho / 1024; } }

        public bool? IsPublicado { get; set; }

        public string IsPublicadoDescription
        {
            get
            {
                return (IsPublicado.HasValue && IsPublicado.Value) ? "Sim" : "Não";
            }
        }

        public String IdArquivoTemporario { get; set; }
    }
}

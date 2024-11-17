using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ArquivosSemanaOperativaConvergirPldDTO
    {
        public ArquivosSemanaOperativaConvergirPldDTO()
        {
            Arquivos = new List<ArquivoDadoNaoEstruturadoDTO>();
        }

        public SemanaOperativa SemanaOperativa { get; set; }

        public IList<ArquivoDadoNaoEstruturadoDTO> Arquivos { get; set; }

        public Type GetRealType()
        {
            return this.GetType();
        }
    }
}

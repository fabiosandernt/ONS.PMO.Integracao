


using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;

namespace ONS.PMO.Integracao.Infraestructure.Repository.PMO
{
    public class ArquivoRepository : Repository<Arquivo>, IArquivoRepository
    {
        public ArquivoRepository(WebPmoContext context) : base(context)
        {
        }

        public IList<Arquivo> ConsultarArquivosAssociadosGabaritos(IList<int> idsGabarito)
        {
            throw new NotImplementedException();
        }

        public void DeletarPorIdGabarito(IList<int> idsGabarito)
        {
            throw new NotImplementedException();
        }

        public byte[] GetDataContentFile(Arquivo arquivo)
        {
            throw new NotImplementedException();
        }

        public Arquivo SalvarArquivoContentFile(Arquivo instanciaArquivoAindaNaoSalvo)
        {
            throw new NotImplementedException();
        }
    }
}

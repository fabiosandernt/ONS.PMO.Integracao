using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class SharePointService : ISharePointService
    {
        public void EnviarArquivosSharePoint(ISet<ArquivoDadoNaoEstruturadoDTO> arquivos, string subPasta)
        {
            throw new NotImplementedException();
        }

        public byte[] ObterArquivo(string caminhoArquivo, int? numeroVersao)
        {
            throw new NotImplementedException();
        }
    }
}

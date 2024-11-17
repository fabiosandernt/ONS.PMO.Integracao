using ONS.PMO.Integracao.Application.Dto.PMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface ISharePointService
    {
        byte[] ObterArquivo(string caminhoArquivo, int? numeroVersao);

        /// <summary>
        /// Envia arquivos para a biblioteca do SharePoint 2007 especificada no arquivo de configurações.
        /// </summary>
        /// <param name="arquivos"></param>
        /// <param name="subPasta"></param>
        void EnviarArquivosSharePoint(ISet<ArquivoDadoNaoEstruturadoDTO> arquivos, string subPasta);
    }
}

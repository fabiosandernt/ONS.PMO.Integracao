using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class ColetaInsumoService : IColetaInsumoService
    {
        public void DeletarArquivos(DadosSemanaOperativaDTO dadosSemanaOperativaDto)
        {
            throw new NotImplementedException();
        }

        public void EnviarDadosColetaInsumo(EnviarDadosColetaInsumoFilter filter)
        {
            throw new NotImplementedException();
        }

        public void FecharColeta(DadosSemanaOperativaDTO dadosSemanaOperativaDto)
        {
            throw new NotImplementedException();
        }

        public ParametroPMO MensagemAberturaColetaEditavel(DadosSemanaOperativaDTO dadosSemanaOperativaDto)
        {
            throw new NotImplementedException();
        }

        public ISet<Arquivo> ObterArquivosUpload(ISet<ArquivoDadoNaoEstruturadoDTO> arquivos, bool desconsiderarJaGravadosBancoDados = false)
        {
            throw new NotImplementedException();
        }

        public ColetaInsumo ObterColetaInsumoInformarDadosPorChave(int idColetaInsumo)
        {
            throw new NotImplementedException();
        }

        public ColetaInsumo ObterPorChave(int chave)
        {
            throw new NotImplementedException();
        }

        public ColetaInsumo ObterValidarColetaInsumoInformarDadosPorChave(int idColetaInsumo, byte[] versaoColetaInsumo = null, bool atualizaParaAndamento = false)
        {
            throw new NotImplementedException();
        }

        public ColetaInsumo ObterValidarColetaInsumoMonitorarDadosPorChave(int idColetaInsumo, int idSituacaoColeta)
        {
            throw new NotImplementedException();
        }

        public bool VerificarPermissaoIncluirManutencao()
        {
            throw new NotImplementedException();
        }

        public bool VerificarSeDadosInsumoIguaisColetaAnterior(ColetaInsumo coletaInsumo)
        {
            throw new NotImplementedException();
        }
    }
}

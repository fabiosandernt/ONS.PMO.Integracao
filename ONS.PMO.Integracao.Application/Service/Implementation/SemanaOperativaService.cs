using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class SemanaOperativaService : ISemanaOperativaService
    {
        public void AbrirEstudo(AberturaEstudoDTO dto)
        {
            throw new NotImplementedException();
        }

        public void AlterarSemanaOperativa(DadosAlteracaoSemanaOperativaDTO dadosAlteracao)
        {
            throw new NotImplementedException();
        }

        public void AtualizarSemanasOperativasInclusao(IEnumerable<SemanaOperativa> semanasOperativas, int ano, string nomeMes)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaDTO ConsultarArquivosSemanaOperativaConvergenciaCcee(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaConvergirPldDTO ConsultarArquivosSemanaOperativaConvergenciaPLD(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaDTO ConsultarArquivosSemanaOperativaPublicacaoResultados(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarEstudoConvergenciaPldPorNome(string nomeEstudo)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarEstudoPorNome(string nomeEstudo)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarSemanasOperativasComGabarito()
        {
            throw new NotImplementedException();
        }

        public void ConvergirPLD(ConvergirPLDDTO dto)
        {
            throw new NotImplementedException();
        }

        public void ExcluirSemana(SemanaOperativa semanaOperativa)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa GerarSemanaOperativa(int ano, string nomeMes, DateTime dataInicioSemana, DateTime dataFimPMO, int revisao)
        {
            throw new NotImplementedException();
        }

        public ISet<SemanaOperativa> GerarSugestaoSemanasOperativas(int ano, int mes)
        {
            throw new NotImplementedException();
        }

        public void IniciarConvergenciaCCEE(InicializacaoConvergenciaCceeDTO dto)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaPorChave(int chave)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaPorChaveParaInformarDados(int chave)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaValidaParaAbrirEstudo(DadosSemanaOperativaDTO dto)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaValidaParaResetarGabarito(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public void PublicarResultados(PublicacaoResultadosDTO dto)
        {
            throw new NotImplementedException();
        }

        public void ReprocessarPMO(ReprocessamentoPMODTO dto)
        {
            throw new NotImplementedException();
        }

        public void ResetarGabarito(ResetGabaritoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}

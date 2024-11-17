using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;

namespace ONS.PMO.Integracao.Infraestructure.Repository
{
    public class DadosResultadoPmoRepository : Repository<DadoResultPMO>, IDadosResultadoPmoRepository
    {
        public DadosResultadoPmoRepository(WebPmoContext context) : base(context)
        {
        }

        public async Task<List<DadoResultPMO>> GetDadoResultPmosAsync(DisponibilidadeFilter filter)
        {
            string[] codMnemonicos = new string[] { "Gtmin", "Gtmax", "Cincr" };

            var query = from dado in _context.Set<DadoResultPMO>()
                        join mnemonico in _context.Set<MnemonicoPMO>() on dado.IdMnemonicopmo equals mnemonico.IdMnemonicopmo
                        join lista in _context.Set<ListaResultadoPMO>() on dado.IdListaresultadopmo equals lista.IdListaresultadopmo
                        join origem in _context.Set<OrigemResultadoPMO>() on lista.IdOrigemresultadopmo equals origem.IdOrigemresultadopmo
                        join usina in _context.Set<AuxUsinaMontador>() on origem.CodOrigemresultadopmo equals usina.CodDpp.ToString()
                        join resultadocoleta in _context.Set<ResultadoColetaPMO>() on lista.IdResultadocoletapmo equals resultadocoleta.IdResultadocoletapmo
                        join importacao in _context.Set<ImportacaoPMO>() on lista.IdImportacaopmo equals importacao.IdImportacaopmo
                        join semana in _context.Set<SemanaOperativa>() on importacao.IdSemanaoperativa equals semana.IdSemanaoperativa
                        join situacao in _context.Set<SituacaoSemanaOperacao>() on semana.IdTpsituacaosemanaoper equals situacao.IdTpsituacaosemanaoper
                        join patamar in _context.Set<Patamar>() on dado.IdTppatamar equals patamar.IdTppatamar
                        join tpPatamar in _context.Set<Patamar>() on dado.IdTppatamar equals tpPatamar.IdTppatamar
                        where semana.DatIniciosemana >= filter.DataInicioSemana
                              && semana.DatFimsemana <= filter.DataFimSemana
                              && codMnemonicos.Contains(mnemonico.CodMnemonicopmo)
                              && usina.IdTpusina == "UTE"
                        select new DadoResultPMO
                        {
                            IdDadoresultpmo = dado.IdDadoresultpmo,
                            IdMnemonicopmo = dado.IdMnemonicopmo,
                            IdListaresultadopmo = dado.IdListaresultadopmo,
                            IdTppatamar = dado.IdTppatamar,
                            DscValorcoletadomnemonico = dado.DscValorcoletadomnemonico,
                            Tppatamar = tpPatamar.DscTppatamar,
                            FlgValoroficial = dado.FlgValoroficial,
                            NumEstagio = dado.NumEstagio,
                            IdMnemonicopmoNavigation = new MnemonicoPMO
                            {
                                CodMnemonicopmo = mnemonico.CodMnemonicopmo,
                                NomMnemonicopmo = mnemonico.NomMnemonicopmo
                            },
                            IdListaresultadopmoNavigation = new ListaResultadoPMO
                            {
                                IdListaresultadopmo = lista.IdListaresultadopmo,
                                TbAuxUsinamontador=new AuxUsinaMontador 
                                {
                                 CodDpp = usina.CodDpp,
                                 IdAge = usina.IdAge,
                                 NomCurto = usina.NomCurto,
                                 NomLongo = usina.NomLongo,
                                 CodTpgeracao = usina.CodTpgeracao,
                                 CodSubsistema = usina.CodSubsistema,
                                 IdOrigemcoletamontadorree = usina.IdOrigemcoletamontadorree
                                
                                },
                                IdOrigemresultadopmoNavigation = new OrigemResultadoPMO
                                {
                                    CodOrigemresultadopmo = origem.CodOrigemresultadopmo,
                                    NomOrigemresultadopmo = origem.NomOrigemresultadopmo,
                                    CodOrigemresultadopmopai = origem.CodOrigemresultadopmopai
                                },
                                IdResultadocoletapmoNavigation = new ResultadoColetaPMO
                                {
                                    IdResultadocoletapmo = resultadocoleta.IdResultadocoletapmo,
                                    NomResultadocoletapmo = resultadocoleta.NomResultadocoletapmo
                                },
                                IdImportacaopmoNavigation = new ImportacaoPMO
                                {
                                    IdImportacaopmo = importacao.IdImportacaopmo,
                                    IdSemanaoperativaNavigation = new SemanaOperativa
                                    {
                                        IdSemanaoperativa = semana.IdSemanaoperativa,
                                        NomSemanaoperativa = semana.NomSemanaoperativa,
                                        DatIniciosemana = semana.DatIniciosemana,
                                        DatFimsemana = semana.DatFimsemana,
                                        DatReuniao = semana.DatReuniao,
                                        NumRevisao = semana.NumRevisao,
                                        IdPmo = semana.IdPmo,
                                        IdTpsituacaosemanaoperNavigation = new SituacaoSemanaOperacao
                                        {
                                            DscSituacaosemanaoper = situacao.DscSituacaosemanaoper
                                        }
                                    }
                                }
                            }
                        };
            if (filter.CodDpp != null)
            {
            query = query.Where(x => x.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodDpp == filter.CodDpp);
            }
            query = query.Distinct();
            var sqlQuery = query.ToQueryString();
            Console.WriteLine(sqlQuery);

            //var result = await query.ToListAsync();
            var resultAgrupado = await query.GroupBy(x => x.IdListaresultadopmo).ToListAsync();
            var resultadoFiltrado = resultAgrupado.Skip(filter.Offset.Value).Take(filter.LimiteDeResultados.Value);
            return resultadoFiltrado.SelectMany(g => g).ToList();


        }
    }
}

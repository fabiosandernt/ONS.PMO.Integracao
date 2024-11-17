using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;

namespace ONS.PMO.Integracao.Infraestructure.Repository
{
    public class DadosResultadoPmoRepository : Repository<DadoResultadoPMO>, IDadosResultadoPmoRepository
    {
        public DadosResultadoPmoRepository(WebPmoContext context) : base(context)
        {
        }

        public async Task<List<DadoResultadoPMO>> GetDadoResultPmosAsync(DisponibilidadeFilter filter)
        {
            string[] codMnemonicos = new string[] { "Gtmin", "Gtmax", "Cincr" };

            var query = from dado in _context.Set<DadoResultadoPMO>()
                        join mnemonico in _context.Set<MnemonicoPmo>() on dado.IdMnemonicopmo equals mnemonico.IdMnemonicopmo
                        join lista in _context.Set<ListaResultadoPmo>() on dado.IdListaresultadopmo equals lista.IdListaresultadopmo
                        join origem in _context.Set<OrigemResultadoPmo>() on lista.IdOrigemresultadopmo equals origem.IdOrigemresultadopmo
                        join usina in _context.Set<TbAuxUsinamontador>() on origem.CodOrigemresultadopmo equals usina.CodDpp.ToString()
                        join resultadocoleta in _context.Set<ResultadoColetaPmo>() on lista.IdResultadocoletapmo equals resultadocoleta.IdResultadocoletapmo
                        join importacao in _context.Set<ImportacaoPmo>() on lista.IdImportacaopmo equals importacao.IdImportacaopmo
                        join semana in _context.Set<SemanaOperativa>() on importacao.IdSemanaoperativa equals semana.IdSemanaoperativa
                        join situacao in _context.Set<SituacaoSemanaOperativa>() on semana.IdTpsituacaosemanaoper equals situacao.IdTpsituacaosemanaoper
                        join patamar in _context.Set<Patamar>() on dado.IdTppatamar equals patamar.IdTppatamar
                        join tpPatamar in _context.Set<Patamar>() on dado.IdTppatamar equals tpPatamar.IdTppatamar
                        where semana.DatIniciosemana >= filter.DataInicioSemana
                              && semana.DatFimsemana <= filter.DataFimSemana
                              && codMnemonicos.Contains(mnemonico.CodMnemonicopmo)
                              && usina.IdTpusina == "UTE"
                        select new DadoResultadoPMO
                        {
                            IdDadoresultpmo = dado.IdDadoresultpmo,
                            IdMnemonicopmo = dado.IdMnemonicopmo,
                            IdListaresultadopmo = dado.IdListaresultadopmo,
                            IdTppatamar = dado.IdTppatamar,
                            DscValorcoletadomnemonico = dado.DscValorcoletadomnemonico,
                            Tppatamar = tpPatamar.DscTppatamar,
                            FlgValoroficial = dado.FlgValoroficial,
                            NumEstagio = dado.NumEstagio,
                            IdMnemonicopmoNavigation = new MnemonicoPmo
                            {
                                CodMnemonicopmo = mnemonico.CodMnemonicopmo,
                                NomMnemonicopmo = mnemonico.NomMnemonicopmo
                            },
                            IdListaresultadopmoNavigation = new ListaResultadoPmo
                            {
                                IdListaresultadopmo = lista.IdListaresultadopmo,
                                TbAuxUsinamontador=new TbAuxUsinamontador 
                                {
                                 CodDpp = usina.CodDpp,
                                 IdAge = usina.IdAge,
                                 NomCurto = usina.NomCurto,
                                 NomLongo = usina.NomLongo,
                                 CodTpgeracao = usina.CodTpgeracao,
                                 CodSubsistema = usina.CodSubsistema,
                                 IdOrigemcoletamontadorree = usina.IdOrigemcoletamontadorree
                                
                                },
                                IdOrigemresultadopmoNavigation = new OrigemResultadoPmo
                                {
                                    CodOrigemresultadopmo = origem.CodOrigemresultadopmo,
                                    NomOrigemresultadopmo = origem.NomOrigemresultadopmo,
                                    CodOrigemresultadopmopai = origem.CodOrigemresultadopmopai
                                },
                                IdResultadocoletapmoNavigation = new ResultadoColetaPmo
                                {
                                    IdResultadocoletapmo = resultadocoleta.IdResultadocoletapmo,
                                    NomResultadocoletapmo = resultadocoleta.NomResultadocoletapmo
                                },
                                IdImportacaopmoNavigation = new ImportacaoPmo
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
                                        IdTpsituacaosemanaoperNavigation = new SituacaoSemanaOperativa
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
            var resultadoFiltrado = resultAgrupado.Skip(filter.Offset.Value).Take(filter.Limit.Value);
            return resultadoFiltrado.SelectMany(g => g).ToList();


        }

    }
}

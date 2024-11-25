﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU
{
    public class DadoResultadoPmoDto
    {
        public int Offset { get; set; }
        public List<PmoDto> Pmo { get; set; }
    }
    public class PmoDto
    {
        public int IdPmo { get; set; }
        public List<ListaResultadoPmoDto> ListaResultado { get; set; }
    }
    public class AgenteDto
    {
        public string NomeCurto { get; set; }
        public string NomeLongo { get; set; }
        public int CodDpp { get; set; }
        public List<InsumoDto> Insumo { get; set; }
    }
    public class InsumoDto
    {
        public int MnemonicoId { get; set; }
        public int IdDadoResultado { get; set; }
        public string codSubsistema { get; set; }
        public string codTpGeracao { get; set; }
        public List<GrandezaDto> Grandezas { get; set; }


    }
    public class SemanaOperativaDto
    {
        public int IdSemanaOperativa { get; set; }
        public string NomSemanaOperativa { get; set; }
        public DateTime DataInicioSemana { get; set; }
        public DateTime DataFimSemana { get; set; }
        public DateTime DataReuniao { get; set; }
        public int NumRevisao { get; set; }
        public string dscSituacaoSemanaOperativa { get; set; }

    }
    public class GrandezaDto
    {
        public string NomeGrandeza { get; set; }
        public string CodMnemonicoPMO { get; set; }
        public List<PatamarDto> Patamares { get; set; }

    }
    public class PatamarDto
    {
        public int IdPatamar { get; set; }
        public string Patamar { get; set; }
        public string Valor { get; set; }
    }

    public class ListaResultadoPmoDto
    {
        public int IdImportacao { get; set; }
        public int ListaResultadoId { get; set; }
        public SemanaOperativaDto SemanaOperativa { get; set; }
        public List<AgenteDto> Agentes { get; set; }


    }
}
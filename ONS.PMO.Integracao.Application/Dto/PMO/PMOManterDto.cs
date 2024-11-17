using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class PMOManterDto
    {
        public PMOManterDto()
        {
            SemanasOperativas = new List<SemanaOperativaImputDto>();
        }

        public int Id { get; set; }
        public IList<SemanaOperativaImputDto> SemanasOperativas { get; set; }
        public int MesReferencia { get; set; }
        public int AnoReferencia { get; set; }

        [Display(Name = "Meses a frente para Estudo")]
        //[Range(0, 11, ErrorMessageResourceType = typeof(SGIPMOMessages), ErrorMessageResourceName = "MS009")]
        public int? QuantidadeMesesAdiante { get; set; }

        public byte[] Versao { get; set; }
        public string VersaoPmoString { get; set; }

        public string NomeMesReferencia
        {
            get
            {
                string mes = string.Empty;
                if (MesReferencia > 0)
                {
                    var cultura = CultureInfo.CurrentCulture;
                    mes = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.GetMonthName(MesReferencia));
                }
                return mes;
            }
        }
    }
}

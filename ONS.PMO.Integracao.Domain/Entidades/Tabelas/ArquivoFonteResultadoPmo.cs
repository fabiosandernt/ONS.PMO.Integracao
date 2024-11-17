
namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ArquivoFonteResultadoPmo
{
    public int IdArquivofonteresultpmo { get; set; }

    public string NomArquivofonteresultpmo { get; set; } = null!;

    public virtual ICollection<ResultadoColetaPmo> TbResultadocoletapmos { get; set; } = new List<ResultadoColetaPmo>();
}

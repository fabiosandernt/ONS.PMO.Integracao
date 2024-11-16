using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoColetaNaoEstruturado
{
    public int IdDadocoleta { get; set; }

    public string? ObsDadocoletanaoestruturado { get; set; }

    public virtual DadoColeta IdDadocoletaNavigation { get; set; } = null!;

    public virtual ICollection<Arquivo> IdArquivos { get; set; } = new List<Arquivo>();
}

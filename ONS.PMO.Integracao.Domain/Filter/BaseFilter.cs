
namespace ONS.PMO.Integracao.Domain.Filter
{
    public abstract class BaseFilter : IBaseFilter
    {
        public virtual int? Limit { get; set; } = 10;
        public virtual int? Offset { get; set; }
        public virtual string? Sort { get; set; }
    }
}

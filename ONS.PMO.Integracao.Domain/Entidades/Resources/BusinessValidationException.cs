
namespace ONS.PMO.Integracao.Domain.Entidades.Resources
{
    public class BusinessValidationException : Exception
    {
        public List<string> Errors { get; }

        public BusinessValidationException(IEnumerable<string> errors)
            : base("Ocorreram erros de validação.")
        {
            Errors = errors.ToList();
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Errors);
        }
    }
}

using Newtonsoft.Json;

namespace ONS.PMO.Integracao.Domain.Entidades.Resources
{
    public class BusinessMessage
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }

        private static List<BusinessMessage> Messages;

        // Caminho para o arquivo JSON
        private static readonly string JsonFilePath = "businessMessage.json";

        static BusinessMessage()
        {
            LoadMessagesFromFile();
        }

        // Método para carregar mensagens do arquivo JSON
        private static void LoadMessagesFromFile()
        {
            if (File.Exists(JsonFilePath))
            {
                var json = File.ReadAllText(JsonFilePath);
                Messages = JsonConvert.DeserializeObject<List<BusinessMessage>>(json);
            }
            else
            {
                Messages = new List<BusinessMessage>();
            }
        }

        // Busca uma mensagem pelo código
        public static BusinessMessage Get(string code)
        {
            return Messages.FirstOrDefault(m => m.Code == code);
        }
    }

    // Exceção personalizada para validação
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

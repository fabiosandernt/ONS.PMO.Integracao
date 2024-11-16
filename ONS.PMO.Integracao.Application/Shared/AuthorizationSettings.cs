namespace ONS.PMO.Integracao.Api.Shared
{
    public class AuthorizationSettings
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string UseRsa { get; set; }
        public string RsaModulus { get; set; }
        public string RsaPublicExponent { get; set; }
    }
}

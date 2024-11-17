using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class NotificacaoService : INotificacaoService
    {
        public void NotificarUsuariosPorAgente(int idAgente, string assunto, string mensagem)
        {
            throw new NotImplementedException();
        }

        public void NotificarUsuariosPorAgentes(IList<int> idsAgente, string assunto, string mensagem)
        {
            throw new NotImplementedException();
        }

        public void NotificarUsuariosPorAgentesList(IList<int> idsAgente, string assunto, string mensagem)
        {
            throw new NotImplementedException();
        }

        public void NotificarUsuariosPorPerfil(RolePermissoesPopEnum perfil, string assunto, string mensagem)
        {
            throw new NotImplementedException();
        }
    }
}

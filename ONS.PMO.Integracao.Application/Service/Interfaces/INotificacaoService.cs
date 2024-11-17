using ONS.PMO.Integracao.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface INotificacaoService
    {
        void NotificarUsuariosPorAgente(int idAgente, string assunto, string mensagem);

        void NotificarUsuariosPorAgentes(IList<int> idsAgente, string assunto, string mensagem);
        
        void NotificarUsuariosPorAgentesList(IList<int> idsAgente, string assunto, string mensagem);

        void NotificarUsuariosPorPerfil(RolePermissoesPopEnum perfil, string assunto, string mensagem);
    }
}

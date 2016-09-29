using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Services
{
    public interface ISecurityProvider : IService
    {
        bool Authenticate(string username, SecureString password);
        void SaveCredentials(string username, SecureString password);
        bool RetreiveCredentials(ref string username, ref SecureString password);
    }
}

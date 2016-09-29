using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Security
{
    public class UserPrincipal
    {
        public string UserName { get; set; }

        public OperationPermission Permissions { get; set; }

    }
}

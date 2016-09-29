using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Security
{
    [Flags]
    public enum OperationPermission
    {
        Edit,
        Create,
        Delete,
        FileSystem,
        All = Edit | Create | Delete | FileSystem
    }
}

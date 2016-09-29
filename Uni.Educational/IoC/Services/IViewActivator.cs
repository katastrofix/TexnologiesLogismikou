using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uni.Educational.IoC.Services
{
    public interface IViewActivator : IService
    {
        Form CreateForm(string domain, string name, Dictionary<string, object> arguments);
    }
}

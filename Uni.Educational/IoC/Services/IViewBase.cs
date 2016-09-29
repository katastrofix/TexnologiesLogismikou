using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Services
{
    public interface IViewBase
    {
        Dictionary<string, object> Arguments { get; set; }

        ApplicationContext ApplicationContext { get; set; }

        void Initialize(ApplicationContext context, Dictionary<string, object> arguments);
    }
}

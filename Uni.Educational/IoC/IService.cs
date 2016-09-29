using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC
{
    public interface IService
    {
        ApplicationContext ApplicationContext { get; set; }
        void Initialize();
        void Shutdown();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC
{
    public class ApplicationContext
    {
        public ServiceLocator Locator { get; set; }

        public View.Base.WindowManager WindowManager { get; set; }
    }
}

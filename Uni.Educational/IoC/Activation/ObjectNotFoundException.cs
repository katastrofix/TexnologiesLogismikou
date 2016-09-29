using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uni.Educational.IoC.Activation
{
    class ObjectNotFoundException : Exception
    {
        public ObjectNotFoundException(string message)
            : base(message)
        {

        }
    }
}

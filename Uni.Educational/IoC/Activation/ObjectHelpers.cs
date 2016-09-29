using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Activation
{
    public class ObjectHelpers
    {
        public static string GetObjectTypeLiteral(ObjectType type)
        {
            switch (type)
            {
                case ObjectType.UIElement:
                    return "UI";
                case ObjectType.Operation:
                    return "OP";
                case ObjectType.System:
                    return "SYS";
                default:
                    return String.Empty;
            }
        }

    }
}

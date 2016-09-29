using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Educational.IoC;

namespace Uni.Educational.IoC.Services
{
    public interface ILogger : IService
    {
        void LogError(string message);
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}

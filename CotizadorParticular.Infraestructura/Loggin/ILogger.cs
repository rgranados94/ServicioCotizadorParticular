using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Infraestructura.Loggin
{
    public interface ILogger
    {
        void Configure();
        void Error(object message);
        void Error(object message, Exception exception);
        void Info(object message);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Infraestructura.Loggin
{
    public class Logger :ILogger
    {
        private static ILog _log { get; set; }

        private string _rutaNombreArchivo = "";
        private string _patronRegistro = "";
        private string _tamanioMaximo = "";
        private int _cantidadBackups = 0;

        public Logger()
        {
            _log = LogManager.GetLogger(typeof(Logger));
            _rutaNombreArchivo = ConfigurationManager.AppSettings["LoggerNombreRutaArchivo"].ToString();
            _patronRegistro = ConfigurationManager.AppSettings["LoggerPatronRegistro"].ToString();
            _tamanioMaximo = ConfigurationManager.AppSettings["LoggerTamanioMaximo"].ToString();
            _cantidadBackups = int.Parse(ConfigurationManager.AppSettings["LoggerCantidadBackups"].ToString());

            Configure();
        }

        public void Configure()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = _patronRegistro;
            patternLayout.ActivateOptions();

            hierarchy.Root.RemoveAllAppenders();
            RollingFileAppender roller = new RollingFileAppender();
            roller.AppendToFile = true;
            roller.File = _rutaNombreArchivo;
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = _cantidadBackups;
            //------------------------------------------------------
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.MaximumFileSize = _tamanioMaximo;
            roller.StaticLogFileName = true;
            //------------------------------------------------------
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

            hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }

        public void Error(object message)
        {
            _log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            if (exception is SqlException)
            {
                var sqlException = (SqlException)exception;
                foreach (SqlError sqlError in sqlException.Errors)
                {
                    var mensajeErrorSql = string.Format("Error en BD. Procedimiento {0}, Linea {1}, Mensaje: {2}",
                        sqlError.Procedure,
                        sqlError.LineNumber,
                        sqlError.Message);

                    _log.Error(mensajeErrorSql);
                }
            }

            _log.Error(message, exception);
        }

        public void Info(object message)
        {
            _log.Info(message);
        }
    }
}

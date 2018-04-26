

using NLog.Extensions.Logging;

public class Startup
{
	
	
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
    {
        // Agregar NLog para que se encargue del registro.
        loggerFactory.AddNLog();
    }
}

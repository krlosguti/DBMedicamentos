using DBMedicamentos.Data;
using Microsoft.EntityFrameworkCore;

namespace DBMedicamentos.Configuraciones
{
    public static class AplicacionDbContextFactory
    {
        public static void ConfigureAplicacionDbContext(IServiceCollection services, IConfiguration configuration)
        {
            // Configurar la cadena de conexión desde appsettings.json en dbmedicamentos
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Registrar el ApplicationDbContext e IDbContext
            services.AddDbContext<AplicacionDbContext>(options =>
                options.UseSqlServer(connectionString));



            // Registrar la interfaz IDbContext para ser usada en otros proyectos
            services.AddScoped<IAplicacionDbContext, AplicacionDbContext>();
        }
    }
}

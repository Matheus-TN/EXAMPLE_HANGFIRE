using EXAMPLE_HANGFIRE.JOBs;
using Hangfire;
using Hangfire.MemoryStorage;

namespace EXAMPLE_HANGFIRE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configurar o servi�o do HangFire e a persist�ncia usada e servidor de processamento
            builder.Services.AddHangfire(op =>
            {
                op.UseMemoryStorage();
            });

            builder.Services.AddHangfireServer();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Adiciona o middleware do Dashboard para visualizar as a��es
            app.UseHangfireDashboard();

            // Met�do para facilitar o acionamento dos jobs
            Initialize.StartJobs();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
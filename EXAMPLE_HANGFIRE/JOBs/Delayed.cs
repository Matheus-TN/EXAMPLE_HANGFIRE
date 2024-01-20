using Hangfire;

namespace EXAMPLE_HANGFIRE.JOBs
{
    public static class Delayed
    {
        public static void Job()
        {
            // Faz o agendamento do processo a ser executado
            BackgroundJob.Schedule(() => Console.WriteLine("Iniciei Delayed !!"), TimeSpan.FromMinutes(1));
        }
    }
}

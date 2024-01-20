using Hangfire;

namespace EXAMPLE_HANGFIRE.JOBs
{
    public static class Recurring
    {
        public static void Job()
        {
            // Faz o agendamento recorrente do processo a ser executado. São tarefas que executam de tempos em tempos
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Iniciei Reccuring !!"), Cron.Minutely);
        }
    }
}

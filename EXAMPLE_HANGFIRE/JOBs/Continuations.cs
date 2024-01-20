using Hangfire;

namespace EXAMPLE_HANGFIRE.JOBs
{
    public static class Continuations
    {
        public static void Job()
        {
            // São "tarefas filhas" cujas execuções acontecem após a tarefa pai ser processada 
            string jobPaiId = BackgroundJob.Enqueue(() => Console.WriteLine("Iniciei Job Pai !!"));

            BackgroundJob.ContinueJobWith(jobPaiId, () => Console.WriteLine("Iniciei Job Filha !!"));
        }
    }
}

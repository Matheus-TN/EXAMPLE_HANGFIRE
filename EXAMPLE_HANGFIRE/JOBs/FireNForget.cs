using Hangfire;

namespace EXAMPLE_HANGFIRE.JOBs
{
    public static class FireNForget
    {
        public static void Job()
        {
            // São executados apenas uma única vez e quase que imediato após a criação
            BackgroundJob.Enqueue(() => Console.WriteLine("Iniciei o Fire and Forget !!"));
        }
    }
}

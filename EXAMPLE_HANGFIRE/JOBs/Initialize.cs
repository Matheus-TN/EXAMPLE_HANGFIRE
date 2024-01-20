namespace EXAMPLE_HANGFIRE.JOBs
{
    public static class Initialize
    {
        public static void StartJobs()
        {
            FireNForget.Job();

            Recurring.Job();

            Delayed.Job();

            Continuations.Job();
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

class PeriodicTimerWorker
{
    static async Task Main(string[] args)
    {
        using var cts = new CancellationTokenSource();

        // Cancel the timer after 10 seconds for demonstration purposes
        cts.CancelAfter(TimeSpan.FromSeconds(10));

        Console.WriteLine("Starting periodic worker. It will run for 10 seconds...");

        try
        {
            await RunWorkerAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Worker was cancelled.");
        }

        Console.WriteLine("Worker stopped.");
    }

    static async Task RunWorkerAsync(CancellationToken cancellationToken)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromSeconds(2));

        while (await timer.WaitForNextTickAsync(cancellationToken))
        {
            Console.WriteLine($"Worker tick at {DateTime.Now:HH:mm:ss}");
            // Perform some work here
        }
    }
}

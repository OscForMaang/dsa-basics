using System.Threading.Tasks;

namespace Searching
{
    internal class MyTask
    {
        public void Work(CancellationToken masterCancellationToken)
        {
			try
			{
                var taskCts = CancellationTokenSource.CreateLinkedTokenSource(masterCancellationToken);
                taskCts.CancelAfter(TimeSpan.FromMinutes(1));
                int i = 0;
                taskCts.Token.Register(() =>
                {
                    Console.WriteLine("Timing out");
                });
                Console.WriteLine("Waiting");
                Console.ReadLine();
                while (true)
                {
                    Thread.Sleep(1000);
                    i++;
                    Console.WriteLine(i);
                    taskCts.Token.ThrowIfCancellationRequested();
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                if (ex.GetType() == typeof(OperationCanceledException))
                {
                    Console.WriteLine("Operation cancelled by timeout");
                }
                else
                {
                    Console.WriteLine("Operation cancelled by generic exception");
                }
            }
        }
    }
}

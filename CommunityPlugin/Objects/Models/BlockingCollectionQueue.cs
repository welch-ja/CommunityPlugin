
using CommunityPlugin.Objects.Interface;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace CommunityPlugin.Objects.Models
{
    public class BlockingCollectionQueue
    {
        BlockingCollection<ITask> tasks = new BlockingCollection<ITask>();

        public BlockingCollectionQueue()
        {
            var worker = new Thread(new ThreadStart(Work));
            worker.IsBackground = true;
            worker.Start();
        }

        public void EnqueueTask(ITask Task)
        {
            tasks.Add(Task);
        }

        private void Work()
        {
            foreach (ITask task in tasks.GetConsumingEnumerable(CancellationToken.None))
            {
                try
                {
                    task.Run().Invoke();
                }
                catch (Exception ex)
                {
                    Logger.HandleError(ex, nameof(BlockingCollectionQueue));
                }
            }
        }
    }
}

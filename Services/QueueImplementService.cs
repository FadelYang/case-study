
namespace Services
{
    public class QueueImplementService : IQueueImplementService
    {
        private readonly Queue<string> _queue = new();

        public IEnumerable<string> GetQueueItems()
        {
            return _queue;
        }

        public void AddQueueItem(string item)
        {
            _queue.Enqueue(item);
        }

        public void RemoveQueueItem()
        {
            _queue.Dequeue();
        }
    }
}
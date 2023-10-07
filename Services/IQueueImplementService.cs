namespace Services
{
    public interface IQueueImplementService
    {
        IEnumerable<string> GetQueueItems();

        void AddQueueItem(string item);

        void RemoveQueueItem();
    }
}
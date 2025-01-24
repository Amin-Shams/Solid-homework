namespace ZooApp.Database
{
    public class DataSaver
    {
        private readonly ILogger _logger;

        public DataSaver(ILogger logger)
        {
            _logger = logger;
        }

        public void Save(string input, string timestamp)
        {
            // save data
            _logger.Log($"Data Saved: {input}|{timestamp}");
        }
    }
}

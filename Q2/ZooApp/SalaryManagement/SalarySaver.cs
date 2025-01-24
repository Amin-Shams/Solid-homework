namespace ZooApp
{
    public class SalarySaver
    {
        private readonly DataStorage _dataStorage;
        private readonly ILogger _logger;

        public SalarySaver(DataStorage dataStorage, ILogger logger)
        {
            _dataStorage = dataStorage;
            _logger = logger;
        }

        public void SaveSalary(long salary, string timestamp)
        {
            _dataStorage.AddData($"Salary: {salary} | Timestamp: {timestamp}");
            _logger.Log($"Salary saved: {salary} | {timestamp}");
        }
    }
}

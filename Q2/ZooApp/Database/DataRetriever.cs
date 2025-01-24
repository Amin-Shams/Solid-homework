using ZooApp.Log;

namespace ZooApp.Database{
    public class DataRetriever
    {
        private readonly List<string> _data;
        private readonly ILogger _logger;

        public DataRetriever(List<string> data, ILogger logger)
        {
            _data = data;
            _logger = logger;
        }

        public string Retrieve(int index)
        {
            if (index < 0 || index >= _data.Count)
            {
                _logger.Log("No data");
                throw new Exception("No Data");
            }
            return _data[index];
        }
    }
}


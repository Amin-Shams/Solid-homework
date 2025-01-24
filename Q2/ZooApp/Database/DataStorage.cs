namespace ZooApp.Database
{
    public class DataStorage
    {
        private readonly List<string> _data;

        public DataStorage()
        {
            _data = new List<string>();
        }

        public void AddData(string data)
        {
            _data.Add(data);
        }
    }
}

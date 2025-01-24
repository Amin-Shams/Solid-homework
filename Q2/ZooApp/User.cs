using ZooApp.Log;
using ZooApp.Database;

namespace ZooApp
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
    }

    public class UserAdder
    {
        private readonly DataStorage _dataStorage;
        private readonly ILogger _logger;

        public UserAdder(DataStorage dataStorage, ILogger logger)
        {
            _dataStorage = dataStorage;
            _logger = logger;
        }

        public void AddUser(User user)
        {
            _dataStorage.AddData($"AddUser: {user.Email}");
            _logger.Log($"User added: {user.Email}");
        }
    }
    
    public class UserRemover
    {
        private readonly DataStorage _dataStorage;
        private readonly ILogger _logger;

        public UserRemover(DataStorage dataStorage, ILogger logger)
        {
            _dataStorage = dataStorage;
            _logger = logger;
        }

        public void RemoveUser(User user)
        {
            _dataStorage.AddData($"RemoveUser: {user.Email}");
            _logger.Log($"User removed: {user.Email}");
        }
    }

}



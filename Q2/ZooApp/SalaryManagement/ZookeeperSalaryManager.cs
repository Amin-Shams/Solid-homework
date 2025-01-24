namespace ZooApp
{
    public class ZookeeperSalaryManager
    {
        private readonly SalaryCalculator _salaryCalculator;
        private readonly SalarySaver _salarySaver;

        public ZookeeperSalaryManager(SalaryCalculator salaryCalculator, SalarySaver salarySaver)
        {
            _salaryCalculator = salaryCalculator;
            _salarySaver = salarySaver;
        }

        public void CalculateAndSaveSalaries(List<User> zookeepers)
        {
            foreach (var zookeeper in zookeepers)
            {
                var salary = _salaryCalculator.CalculateSalary(zookeeper.Id);
                _salarySaver.SaveSalary(salary, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
    }
}

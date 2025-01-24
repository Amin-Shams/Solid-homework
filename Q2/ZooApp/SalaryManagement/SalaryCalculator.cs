namespace ZooApp.SalaryManagement
{
    public class SalaryCalculator
    {
        public long CalculateSalary(long userId)
        {
            return  1099 * userId + new Random().Next(1, 10) + 5; 
        }
}

}
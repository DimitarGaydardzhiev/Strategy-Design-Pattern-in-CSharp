namespace StrategyPattern.SavingStrategy
{
    public class DatabaseSavingStrategy : ISavingStrategy
    {
        public void Save(Stream file)
        {
            Console.WriteLine($"Database storage chosen chosen!");
        }
    }
}

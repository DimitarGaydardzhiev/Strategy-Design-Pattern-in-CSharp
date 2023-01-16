namespace StrategyPattern.SavingStrategy
{
    public class CloudSavingStrategy : ISavingStrategy
    {
        public void Save(Stream file)
        {
            Console.WriteLine($"Cloud storage chosen chosen!");
        }
    }
}

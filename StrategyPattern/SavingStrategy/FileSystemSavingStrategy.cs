namespace StrategyPattern.SavingStrategy
{
    public class FileSystemSavingStrategy : ISavingStrategy
    {
        public void Save(Stream file)
        {
            Console.WriteLine($"File system storage chosen chosen!");
        }
    }
}

using StrategyPattern.SavingStrategy;

namespace StrategyPattern.Services
{
    public class FileService : IFileService
    {
        public void Save(Stream file, ISavingStrategy strategy)
        {
            strategy.Save(file);
        }
    }
}

using StrategyPattern.SavingStrategy;

namespace StrategyPattern.Services
{
    public interface IFileService
    {
        void Save(Stream stream, ISavingStrategy strategy);
    }
}

using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.SavingStrategy;
using StrategyPattern.Services;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFileService, FileService>()
                .BuildServiceProvider();

            Console.WriteLine("Where do you want to store your files?");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Database (D), File system (F), Cloud (C)");
            var storage = Console.ReadLine().ToLower();

            ISavingStrategy savingStrategy = null;
            switch (storage)
            {
                case "d":
                    savingStrategy = new DatabaseSavingStrategy();
                    break;
                case "f":
                    savingStrategy = new FileSystemSavingStrategy();
                    break;
                case "c":
                    savingStrategy = new CloudSavingStrategy();
                    break;
            }

            if (savingStrategy != null)
            {
                var fileService = serviceProvider.GetService<IFileService>();
                using (var stream = new MemoryStream())
                {
                    fileService.Save(stream, savingStrategy);
                }
            }
            else
            {
                throw new ArgumentException("Invalid saving provider!");
            }
        }
    }
}

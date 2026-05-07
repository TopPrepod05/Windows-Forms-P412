using Newtonsoft.Json;
using WinForms02.Models;
namespace WinForms02.Services
{
    public static class DatabaseService
    {
        private static readonly string DataFilePath = "data.json";
        public static AppDatabase Load()
        {
            if(!File.Exists(DataFilePath))
            {
                return new AppDatabase();
            }

            string json = File.ReadAllText(DataFilePath);
            AppDatabase? db = JsonConvert.DeserializeObject<AppDatabase>(json);
            return db ?? new AppDatabase();
        }

        public static void Save(AppDatabase database)
        {
            string json = JsonConvert.SerializeObject(database, Formatting.Indented);
            File.WriteAllText(DataFilePath, json);
        }
    }
}

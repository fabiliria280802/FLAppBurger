using FLAppBurger.Models;
using SQLite;
namespace FLAppBurger.Data
{
    public class FLBurgerDatabase
    {
        string _dbPath;
        public SQLiteConnection conn;
        public FLBurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<FLBurger>();
        }
        public int AddNewBurger(FLBurger flburger)
        {
            Init();
            int result = conn.Insert(flburger);
            return result;
        }
        public List<FLBurger> GetAllBurgers()
        {
            Init();
            List<FLBurger> burgers = conn.Table<FLBurger>().ToList();
            return burgers;
        }
    }
}

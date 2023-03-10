using FLAppBurger.Models;
using SQLite;
using FLAppBurger.ViewModels;
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
            //int result = conn.Insert(flburger);
            //return result;
            if (flburger.Id != 0)
            {
                return conn.Update(flburger);
            }
            else
            {
                return conn.Insert(flburger);
            }
        }
        public List<FLBurger> GetAllBurgers()
        {
            Init();
            List<FLBurger> burgers = conn.Table<FLBurger>().ToList();
            return burgers;
        }
        public int DeleteItem(FLBurger item)
        {
            Init();
            return conn.Delete(item);
        }
        public FLBurger ShowItem(FLBurger item)
        {
            Init();
            List<FLBurger> burgers = conn.Table<FLBurger>().ToList();
            //foreach item in burgers():
            return null;
            //aqui falta codigo que recorra la lista en busca de  los datos de una determinada hamburgesa
        }
    }
}

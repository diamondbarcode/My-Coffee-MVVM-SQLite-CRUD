using SQLite;

namespace MyCoffeeMVVMSQLite.Models
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } // need to write an encryption fuction        
    }
}

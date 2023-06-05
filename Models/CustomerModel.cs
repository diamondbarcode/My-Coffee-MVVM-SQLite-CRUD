using SQLite;

namespace MyCoffeeMVVMSQLite.Models
{
    public  class CustomerModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
    }
}

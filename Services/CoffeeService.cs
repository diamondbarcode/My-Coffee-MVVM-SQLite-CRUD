using MyCoffeeMVVMSQLite.Services;
using MyCoffeeMVVMSQLite.Models; // use this to get " Coffee " to work and Coffee is Model name 

using SQLite; // https://github.com/praeclarum/sqlite-net?WT.mc_id=friends-0000-jamont


[assembly: Microsoft.Maui.Controls.Dependency(typeof(CoffeeService))] // not sure what this does yet ..
namespace MyCoffeeMVVMSQLite.Services
{
    public class CoffeeService : ICoffeeService // inherited from ICoffeeService Files ..
    {
        SQLiteAsyncConnection db;

        async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            // var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db"); << xamarin ??
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CoffeeDatabase.db");

            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<CoffeeModel>(); // Create Table 

            // Debug Test write to console what this does and when it done
            Console.WriteLine("Table Created");
        }

        public async Task AddCoffee(string name, string roaster)
        {
            await Init();

            var image = "coffeebag.png";
            var coffee = new CoffeeModel
            {
                Name = name,
                Roaster = roaster,
                Image = image
            };

            var id = await db.InsertAsync(coffee); // add new record to db and return int as new id
        }

        public async Task RemoveCoffee(int id)
        {

            await Init();

            await db.DeleteAsync<CoffeeModel>(id); // remove a record base on primary key ID
        }

        public async Task<IEnumerable<CoffeeModel>> GetCoffee() // return all coffeee aka get coffee list .. if use GetCoffee() without ID
        {
            await Init();

            var coffee = await db.Table<CoffeeModel>().ToListAsync();
            return coffee;
        }

        public async Task<CoffeeModel> GetCoffee(int id)  // return specific coffee ..  if use GetCoffee(2) with ID 
        {
            await Init();

            var coffee = await db.Table<CoffeeModel>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return coffee;
        }

    }
}


/*
 
  private SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<StudentModel>();
            }
        }

        public async Task<int> AddStudent(StudentModel studentModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(studentModel);
        }

        public async Task<int> DeleteStudent(StudentModel studentModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(studentModel);
        }

        public async Task<List<StudentModel>> GetStudentList()
        {
            await SetUpDb();
            var studentList = await _dbConnection.Table<StudentModel>().ToListAsync();
            return studentList;
        }

        public async Task<int> UpdateStudent(StudentModel studentModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(studentModel);
        }
 */

using MyCoffeeMVVMSQLite.Models;

namespace MyCoffeeMVVMSQLite.Services
{
    public interface ICoffeeService
    {
        // Task<List<Coffee>> GetCoffeeList();
        Task AddCoffee(string name, string roaster);
        Task<IEnumerable<CoffeeModel>> GetCoffee();
        Task<CoffeeModel> GetCoffee(int id);
        Task RemoveCoffee(int id);

        /*        
        Task<List<StudentModel>> GetStudentList();
        Task<int> AddStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
        Task<int> UpdateStudent(StudentModel studentModel);                  
         */

    }
}

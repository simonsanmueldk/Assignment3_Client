using Assignment2.Models;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public interface IUserService
    {
       Task<User> ValidateUserAsync(string username, string password);
    }
}
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Data
{
    public interface IUserService
    {
       Task<User> ValidateUserAsync(string username, string password);
    }
}
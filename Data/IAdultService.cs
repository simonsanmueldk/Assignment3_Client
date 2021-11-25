using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Data
{
public interface IAdultService
{
    Task AddAdultAsync(Adult adultToAdd);
    Task<IList<Adult>> ReadAllAdults();
    Task UpdateAdult(Adult adultToUpdate);
    Task DeleteAdult(Adult adultToDelete);
}
}


using Forum.Entities;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Contracts
{
    public interface IUserService
    {
        Task AddUserAsync(User model);
        Task DeleteUserAsync(int id);
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
        Task UpdateUserAsync(UserForUpdateDto model);
    }
}

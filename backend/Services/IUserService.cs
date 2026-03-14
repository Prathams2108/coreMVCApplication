using System;
using backend.Dto;
using backend.Models;

namespace backend.Services
{
    public interface IUserService
    {
        Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
        Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
        Task <bool> DeleteUserAsync(string userId);
        Task <User> UpdateUserAsync(string userId, RegisterDto updateDto);
        // Define methods for user management, e.g., registration, authentication, etc.
    }
}
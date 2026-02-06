using eCommerce.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.ServiceContracts;

/// <summary>
/// Contract for UsersService that contains use cases for users
/// </summary>
public interface IUsersService
{
    /// <summary>
    /// Method to handle user login use case and returns an AuthenticationResponse object that contains status of login
    /// </summary>
    /// <param name="loginRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> Login(LoginRequest loginRequest);

    /// <summary>
    /// Method to handle user registeration use case and returns an AuthenticationResponse object that represents status of user registration
    /// </summary>
    /// <param name="registerRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
}

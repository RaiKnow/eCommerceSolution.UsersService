using eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.RepositoryContracts;

/// <summary>
/// Contract to be implemented by UserRepository that contains data access logic of users data store
/// </summary>
public interface IUsersRepository
{
    /// <summary>
    /// Method to add a user in the data store and return the added user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<ApplicationUser?> AddUser(ApplicationUser user);

    /// <summary>
    /// Method to retreive the existing user by their email and password
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
}

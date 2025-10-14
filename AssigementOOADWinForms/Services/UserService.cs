using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;
using AssigementOOADWinForms.Repositries;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AssigementOOADWinForms.Services
{
    public class UserService
    {
        private readonly UserRepository _repo = new();
        public List<User> GetAllUsers() => _repo.GetAllUsers();
        public void SaveUser(User model) => _repo.Save(model);
        public void RemoveUser(int userId) => _repo.Delete(userId);
    }
}

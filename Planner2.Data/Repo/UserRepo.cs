﻿using Microsoft.EntityFrameworkCore;
using Planner2.Data.DataContext;
using Planner2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner2.Data.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly PlannerContext _ctx;
        public UserRepo(PlannerContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<Users>> GetUsersAsync()
        {
            var users = await _ctx.Users.ToListAsync();
            return users;
        }
        public async Task<Users> GetUsersByIdAsync(int id)
        {
            return await _ctx.Users.FindAsync(id);
        }
        public async Task<Users> CreateUserAsync(Users user)
        {
            _ctx.Users.Add(user);
            await _ctx.SaveChangesAsync();
            return user;
        }
        public async Task UpdateUserAsync(Users user)
        {
            _ctx.Users.Update(user);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteUserAsync(Users user)
        {
            _ctx.Users.Remove(user);
            await _ctx.SaveChangesAsync();
        }
    }
}

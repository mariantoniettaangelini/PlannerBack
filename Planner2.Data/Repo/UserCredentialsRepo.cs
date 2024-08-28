using Microsoft.EntityFrameworkCore;
using Planner2.Data.DataContext;
using Planner2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner2.Data.Repo
{
    //public class UserCredentialsRepo : IUserCredentialsRepo
    //{
        //private readonly PlannerContext _ctx;
        //public UserCredentialsRepo(PlannerContext ctx)
        //{
        //    _ctx = ctx;
        //}

        //public async Task<IEnumerable<UserCredentials>> GetCredentialsAsync()
        //{
        //    var credentials = await _ctx.UserCredentials.ToListAsync();
        //    return credentials;
        //}

        //public async Task<UserCredentials> GetCredentialsByIdAsync(int id)
        //{
        //    return await _ctx.UserCredentials.FindAsync(id);
        //}

        //public async Task<UserCredentials> CreateCredentialsAsync(UserCredentials credentials)
        //{
        //    _ctx.UserCredentials.Add(credentials);
        //    await _ctx.SaveChangesAsync();
        //    return credentials;
        //}

        //public async Task UpdateCredentialsAsync(UserCredentials credentials)
        //{
        //    _ctx.UserCredentials.Update(credentials);
        //    await _ctx.SaveChangesAsync();
        //}

        //public async Task DeleteCredentialsAsync(UserCredentials credentials)
        //{
        //    _ctx.UserCredentials.Remove(credentials);
        //    await _ctx.SaveChangesAsync();
        //}
    //}
}

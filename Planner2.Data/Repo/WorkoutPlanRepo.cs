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
    public class WorkoutPlanRepo : IWorkoutPlanRepo
    {
        private readonly PlannerContext _ctx;
        public WorkoutPlanRepo(PlannerContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<WorkoutPlan>> GetPlansAsync()
        {
            var plans = await _ctx.WorkoutPlans.ToListAsync();
            return plans;
        }
        public async Task<WorkoutPlan> GetPlansById(int id)
        {
            return await _ctx.WorkoutPlans.FindAsync(id);
        }
        public async Task<WorkoutPlan> CreatePlanAsync(WorkoutPlan workoutPlan)
        {
            _ctx.WorkoutPlans.Add(workoutPlan);
            _ctx.SaveChanges();
            return workoutPlan;
        }
        public async Task UpdatePlanAsync(WorkoutPlan workoutPlan)
        {
            _ctx.WorkoutPlans.Update(workoutPlan);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeletePlanAsync(WorkoutPlan workoutPlan)
        {
            _ctx.WorkoutPlans.Remove(workoutPlan);
            await _ctx.SaveChangesAsync();
        }
    }
}

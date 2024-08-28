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
    public class ExerciseRepo : IExerciseRepo
    {
        private readonly PlannerContext _ctx;
        public ExerciseRepo(PlannerContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<Exercise>> GetExercisesAsync()
        {
            var exercises = await _ctx.Exercises.ToListAsync();
            return exercises;
        }
        public async Task<Exercise> GetExercisesByIdAsync(int id)
        {
            return await _ctx.Exercises.FindAsync(id);
        }
        public async Task<Exercise> CreateExerciseAsync(Exercise exercise)
        {
            _ctx.Exercises.Add(exercise);
            _ctx.SaveChanges();
            return exercise;
        }
        public async Task UpdateExerciseAsync(Exercise exercise)
        {
            _ctx.Exercises.Update(exercise);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteExerciseAsync(Exercise exercise)
        {
            _ctx.Exercises.Remove(exercise);
            await _ctx.SaveChangesAsync();
        }
    }
}

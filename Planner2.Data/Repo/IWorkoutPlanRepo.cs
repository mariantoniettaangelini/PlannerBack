using Planner2.Data.Models;

namespace Planner2.Data.Repo
{
    public interface IWorkoutPlanRepo
    {
        Task<WorkoutPlan> CreatePlanAsync(WorkoutPlan workoutPlan);
        Task DeletePlanAsync(WorkoutPlan workoutPlan);
        Task<IEnumerable<WorkoutPlan>> GetPlansAsync();
        Task<WorkoutPlan> GetPlansById(int id);
        Task UpdatePlanAsync(WorkoutPlan workoutPlan);
    }
}
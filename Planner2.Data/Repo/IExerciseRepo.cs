using Planner2.Data.Models;

namespace Planner2.Data.Repo
{
    public interface IExerciseRepo
    {
        Task<Exercise> CreateExerciseAsync(Exercise exercise);
        Task DeleteExerciseAsync(Exercise exercise);
        Task<IEnumerable<Exercise>> GetExercisesAsync();
        Task<Exercise> GetExercisesByIdAsync(int id);
        Task UpdateExerciseAsync(Exercise exercise);
    }
}
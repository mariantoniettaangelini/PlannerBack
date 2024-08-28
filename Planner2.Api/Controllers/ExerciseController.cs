using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner2.Data.Models;
using Planner2.Data.Repo;

namespace Planner2.Api.Controllers
{
    [Route("api/exercise")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseRepo _exerciseRepo;
        private readonly ILogger<ExerciseController> _logger;
        public ExerciseController(ILogger<ExerciseController> logger, IExerciseRepo exerciseRepo)
        {
            _logger = logger;
            _exerciseRepo = exerciseRepo;
        }
        [HttpPost]
        public async Task<IActionResult> AddExercise(Exercise exercise)
        {
            try
            {
                var created = await _exerciseRepo.CreateExerciseAsync(exercise); 
                return CreatedAtAction(nameof(AddExercise), created);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateExercise(Exercise exercise)
        {
            try
            {
                var existingExercise = await _exerciseRepo.GetExercisesByIdAsync(exercise.Id);
                if (existingExercise == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "exercise not found"
                    });
                }
                existingExercise.Name = exercise.Name;
                existingExercise.Description = exercise.Description;
                existingExercise.MuscleGroup = exercise.MuscleGroup;
                existingExercise.Type = exercise.Type;
                existingExercise.Duration = exercise.Duration;
                existingExercise.Level = exercise.Level;
                existingExercise.Img = exercise.Img;

                await _exerciseRepo.UpdateExerciseAsync(existingExercise);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        StatusCode = 500,
                        message = ex.Message
                    });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            try
            {
                var existingExercise = await _exerciseRepo.GetExercisesByIdAsync(id);
                if(existingExercise == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "exercise not found"
                    });
                }
                await _exerciseRepo.DeleteExerciseAsync(existingExercise);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        StatusCode = 500,
                        message = ex.Message
                    });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetExercises()
        {
            try
            {
                var exercise = await _exerciseRepo.GetExercisesAsync();
                return Ok(exercise);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        StatusCode = 500,
                        message = ex.Message
                    });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExerciseById(int id)
        {
            try
            {
                var exercise = await _exerciseRepo.GetExercisesByIdAsync(id);
                if(exercise == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "exercise not found"
                    });
                }
                return Ok(exercise);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        StatusCode = 500,
                        message = ex.Message
                    });
            }
        }

    }
}

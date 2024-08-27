using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner2.Data.Models;
using Planner2.Data.Repo;

namespace Planner2.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserRepo userRepo, ILogger<UserController> logger)
        {
            _userRepo = userRepo;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            try
            {
                var createdUser = await _userRepo.CreateUserAsync(user);
                return CreatedAtAction(nameof(AddUser), createdUser);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User userToUpdate)
        {
            try
            {
                var existingUser = await _userRepo.GetUsersByIdAsync(userToUpdate.Id);
                if(existingUser == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "record not found"
                    });
                }
                existingUser.Name= userToUpdate.Name;
                existingUser.Email= userToUpdate.Email;
                await _userRepo.UpdateUserAsync(existingUser);
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
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var existingUser = await _userRepo.GetUsersByIdAsync(id);
                if (existingUser == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "record not found"
                    });
                }
                await _userRepo.DeleteUserAsync(existingUser);
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
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userRepo.GetUsersAsync();
                
                return Ok(users);
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
        public async Task<IActionResult> GetUsers(int id)
        {
            try
            {
                var user = await _userRepo.GetUsersByIdAsync(id);
                if (user == null)
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = "record not found"
                    });
                }
                return Ok(user);
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

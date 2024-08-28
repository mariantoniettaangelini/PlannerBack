using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner2.Data.Models;
using Planner2.Data.Repo;

namespace Planner2.Api.Controllers
{
    //[Route("api/usercredentials")]
    //[ApiController]
    //public class UserCredentialsController : ControllerBase
    //{
        //private readonly IUserCredentialsRepo _userCredentialsRepo;
        //private readonly ILogger<UserController> _logger;
        //public UserCredentialsController(IUserCredentialsRepo userCredentialsRepo, ILogger<UserController> logger)
        //{
        //    _userCredentialsRepo = userCredentialsRepo;
        //    _logger = logger;
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddCredentials(UserCredentials credentials)
        //{
        //    try
        //    {
        //        var createdCredentials = await _userCredentialsRepo.CreateCredentialsAsync(credentials);
        //        return CreatedAtAction(nameof(AddCredentials), createdCredentials);
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateCredentials(UserCredentials credentialsToUpdate)
        //{
        //    try
        //    {
        //        var existingCredentials = await _userCredentialsRepo.GetCredentialsByIdAsync(credentialsToUpdate.Id);
        //        if (existingCredentials == null)
        //        {
        //            return NotFound(new
        //            {
        //                StatusCode = 404,
        //                message = "credentials not found"
        //            });
        //        }
        //        else 
        //        {
        //            existingCredentials.Username = credentialsToUpdate.Username;
        //            existingCredentials.Password = credentialsToUpdate.Password;
        //            await _userCredentialsRepo.UpdateCredentialsAsync(existingCredentials);
        //            return NoContent();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError, new
        //        {
        //            StatusCode = 500,
        //            message = ex.Message
        //        });
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCredentials(int id)
        //{
        //    try
        //    {
        //        var existingCredentials = await _userCredentialsRepo.GetCredentialsByIdAsync(id);
        //        if(existingCredentials == null)
        //        {
        //            return NotFound(new
        //            {
        //                StatusCode = 404,
        //                message = "credentials not found"
        //            });
        //        }
        //        await _userCredentialsRepo.DeleteCredentialsAsync(existingCredentials); 
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            new
        //            {
        //                StatusCode = 500,
        //                message = ex.Message
        //            });
        //    }
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetCredentials()
        //{
        //    try
        //    {
        //        var credentials = await _userCredentialsRepo.GetCredentialsAsync();
        //        return Ok(credentials);
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            new
        //            {
        //                StatusCode = 500,
        //                message = ex.Message
        //            });
        //    }
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCredentials(int id)
        //{
        //    try
        //    {
        //        var credentials = await _userCredentialsRepo.GetCredentialsByIdAsync(id);
        //        if(credentials == null)
        //        {
        //            return NotFound(new
        //            {
        //                StatusCode = 404,
        //                message = "credentials not found"
        //            });
        //        }
        //        return Ok(credentials);
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            new
        //            {
        //                StatusCode = 500,
        //                message = ex.Message
        //            });
        //    }
        //}

    //}
}

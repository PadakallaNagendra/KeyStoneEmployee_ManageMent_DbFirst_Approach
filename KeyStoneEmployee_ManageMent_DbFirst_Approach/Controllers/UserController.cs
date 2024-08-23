using KeyStoneEmployee_ManageMent_BusinessObject.InterFace;
using KeyStoneEmployee_ManageMent_BusinessObject.ModelDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeyStoneEmployee_ManageMent_DbFirst_Approach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService _UserService;
        public UserController(IUserService userService)
        {
            _UserService = userService;
        }
        [HttpGet(Name = "UserRegistation")]
        public async Task<IActionResult> UserRegistation()
        {
            try
            {
                var userdata = await _UserService.GetAllRegistation();
                if (userdata != null)
                {
                    return StatusCode(StatusCodes.Status200OK, userdata);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        [HttpPost]
        [Route("AddUserdetails")]
        public async Task<IActionResult> Post([FromBody] UserRegistationDTO userregdetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var userdata = await _UserService.AddUserdetails(userregdetail);
                return StatusCode(StatusCodes.Status201Created, "userregistrtion  Added Succesfully");
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpGet]
        [Route("GetUserRegistationById/{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            if (Id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }
            try
            {
                var userdata = await _UserService.GetUserRegistationById(Id);
                if (userdata == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "userId  not found");
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, userdata);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpDelete]
        [Route("DeleteUserRegistationById/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (Id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }

            try
            {
                var usrdata = await _UserService.DeleteUserRegistationById(Id);
                if (usrdata == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "user Id not found");
                }
                else
                {
                    var Data = await _UserService.DeleteUserRegistationById(Id);
                    return StatusCode(StatusCodes.Status204NoContent, "user details deleted successfully");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpPut]
        [Route("UpdateUserRegistation")]
        public async Task<IActionResult> PUT([FromBody] UserRegistationDTO usrdto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var usrdata = await _UserService.UpdateUserRegistation(usrdto);
                return StatusCode(StatusCodes.Status201Created, " user Details Updated Succesfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

    }
}

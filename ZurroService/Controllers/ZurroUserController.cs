using Microsoft.AspNetCore.Mvc;
using ZurroService.Data;
using ZurroService.Models;

namespace ZurroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZurroUserController : Controller
    {
        private readonly ZurroDBContext zdbContext;

        public ZurroUserController(ZurroDBContext zdbC)
        {
            zdbContext = zdbC;
        }

        /// <summary> Create a new user in the DDBB </summary>
        /// <returns> Status 204 if the user was created successfully. Status 404 if the user was not created</returns>
        [HttpPost("Create a new user")]
        public async Task<IActionResult> CreateZUser([FromBody] DTOCreateZUser userNew)
        {
            if (userNew != null)
            {
                ZUser zuser = new ZUser();

                zuser.Name = userNew.Name;

                zuser.Birthdate = userNew.Birthdate;

                zuser.Active = true;

                zdbContext.ZUser.Add(zuser);

                await zdbContext.SaveChangesAsync();

                return Ok(zuser);
            }
            else 
            {
                return BadRequest(Info.ErrorCreateUser);
            }
        }

        /// <summary> Change the user's "active" status </summary>
        /// <returns> Status 204 if the Active status was changed successfully. Status 404 if the Active status could not be changed</returns>
        [HttpPut("Update active status")]
        public async Task<IActionResult> UpdateStatusActiveZUser(int idUser, [FromBody] DTOModifyActiveZUser userActive)
        {
            var zuser = await zdbContext.ZUser.FindAsync(idUser);

            if (zuser != null)
            {
                zuser.Active = userActive.Active;

                await zdbContext.SaveChangesAsync();

                return Ok(Info.UserChangeStatusActive + zuser.Id);
            }
            else
            {
                return NotFound(Info.ErrorFindUser);
            }
        }

        /// <summary> Delete a user in the DDBB </summary>
        /// <returns> Status 204 if the user was deleted successfully. Status 404 if the user was not deleted</returns>
        [HttpDelete("Delete users")]
        public async Task<IActionResult> DeleteZUser(int idUser)
        {
            var zuser = await zdbContext.ZUser.FindAsync(idUser);

            if (zuser != null)
            {
                zdbContext.ZUser.Remove(zuser);

                await zdbContext.SaveChangesAsync();

                return NoContent();
            }
            else
            {
                return NotFound(Info.ErrorFindUser);
            }
        }

        /// <summary> Get all active user in the DDBB </summary>
        /// <returns> A list of all active users in the DDBB</returns>
        [HttpGet("List all active users")]
        public async Task<ActionResult<IEnumerable<ZUser>>>GetZUserActive()
        {
            var zuserActive = await Task.FromResult(zdbContext.ZUser.Where(x => x.Active == true).ToList());

            return Ok(zuserActive);
        }
    }
}

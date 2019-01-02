using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using taskapi.Data;
namespace taskapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Item : ControllerBase
    {

        private readonly IComonRepository _common;

        public Item(IComonRepository common)
        {
            _common=common;
        }

        [HttpGet("GetAllItem")]   
     public async Task<IActionResult> GetAllItem(){

         var Items = await _common.GetAllItem();
         return Ok(Items);
     }
    }
}
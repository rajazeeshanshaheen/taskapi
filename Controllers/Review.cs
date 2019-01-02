using Microsoft.AspNetCore.Mvc;
using taskapi.Data;
using taskapi.Dtos;
using System.Threading.Tasks;
namespace taskapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Review : ControllerBase
    {
        private readonly IComonRepository _Common ;

        public Review(IComonRepository Common)
        {
            _Common = Common;
        }

      [HttpGet("{id}")]  
      public async Task<IActionResult> GetReviewForItem([FromBody] int id){
          var review = await _Common.GetReviewForAnItem(id);
          return Ok(review);
      }
      [HttpPost ("SaveReview")]

      public async Task<IActionResult>SaveReview([FromBody]reviewForSave reviewForSave){

          var review = await _Common.SaveReview(reviewForSave);
          return StatusCode(201);
      }

    }
}
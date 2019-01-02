using taskapi.Models;
using System.Threading.Tasks;
using taskapi.Dtos;
using System.Collections.Generic;

namespace taskapi.Data

{
    public interface IComonRepository
    {
         Task<List<Item>> GetAllItem();
         Task<review> SaveReview(reviewForSave reviewForSave);

         Task<List<review>> GetReviewForAnItem(int Id);
    }
}
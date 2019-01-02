using System.Threading.Tasks;
using taskapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using taskapi.Dtos;
using System.Collections.Generic;

namespace taskapi.Data
{
    public class CommonRepository : IComonRepository
    {
        private readonly DataContext _context;

        public CommonRepository(DataContext context){
                _context = context;
        }
        public async Task<List<Item>> GetAllItem()
        {
         var Item= await _context.item.ToListAsync();
         return Item;

        }

        public async Task<List<review>> GetReviewForAnItem(int Id)
        {
            var review = await _context.review.Where(x=>x.item_id ==Id).ToListAsync();
            return review;

        }

        public async Task<review> SaveReview(reviewForSave reviewForSave)
        {
            var exist =await _context.item.FirstOrDefaultAsync(x=>x.Id == reviewForSave.itemId);
            if (exist !=null){
                var review = new review();
                review.item_id = reviewForSave.itemId;
                review.comment = reviewForSave.comment;
                await _context.review.AddAsync(review);
                await _context.SaveChangesAsync();
                return review;
            
            }

            return null;


           
        }
    }
}
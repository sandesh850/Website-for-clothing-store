using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class completeOrdersModel : PageModel
    {
        private readonly AppDb _appDb;

        public completeOrdersModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public Tbl_OrderDetails? OrderDetails { get; set; }

        public  async Task<IActionResult> OnGetAsync(int id)
        {
           
            OrderDetails = await _appDb.Tbl_OrderDetails.FindAsync(id);

            if (OrderDetails == null)
            {
                return RedirectToPage("/pendingOrders"); // handle missing record safely
            }

            Tbl_CompleteOrders completeOrders = new Tbl_CompleteOrders
            {
                category = OrderDetails.category,
                ItemType = OrderDetails.ItemType,
                price = OrderDetails.price,
                sizes = OrderDetails.sizes,
                color = OrderDetails.color,
                email = OrderDetails.email,
                address = OrderDetails.address,
                contactNo = OrderDetails.contactNo,
                cardDate = OrderDetails.cardDate,
                img = OrderDetails.img,
                CVCNO = OrderDetails.CVCNO,
                date = OrderDetails.date,
                CardNo = OrderDetails.CardNo
            };

            _appDb.Tbl_CompleteOrders.Add(completeOrders);
            await _appDb.SaveChangesAsync();

            // remove item
            var item = await _appDb.Tbl_OrderDetails.FindAsync(id);

            _appDb.Tbl_OrderDetails.Remove(item);
            await _appDb.SaveChangesAsync();

            return RedirectToPage("/pendingOrders");

        }
    }
}
